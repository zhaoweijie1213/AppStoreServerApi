using AppStoreServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi
{
    public interface IAppleAppstoreClient
    {
        /// <summary>
        /// https://developer.apple.com/documentation/appstoreserverapi/get_transaction_history
        /// </summary>
        /// <param name="originalTransactionId"></param>
        /// <param name="revision"></param>
        /// <returns></returns>
        public Task<HistoryResponse?> GetTransactionHistory(string originalTransactionId, string? revision);

        /// <summary>
        /// https://developer.apple.com/documentation/appstoreserverapi/get_all_subscription_statuses
        /// </summary>
        /// <param name="originalTransactionId"></param>
        /// <returns></returns>
        public Task<StatusResponse?> GetSubscriptionStatuses(string originalTransactionId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Task<OrderLookupResponse?> LookupOrder(string orderId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signedTransactions"></param>
        /// <returns></returns>
        public List<JWSTransactionDecodedPayload> DecodeTransactions(List<string> signedTransactions);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        public DecodedNotificationPayload DecodeNotificationPayload(string payload);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public JWSRenewalInfoDecodedPayload DecodeRenewalInfo(string info);

        /// <summary>
        /// Decodes and verifies an object signed by the App Store according to JWS.
        /// See: https://developer.apple.com/documentation/appstoreserverapi/jwstransaction
        /// </summary>
        /// <param name="token"></param>
        public T DecodeJWS<T>(string token);
    }
}
