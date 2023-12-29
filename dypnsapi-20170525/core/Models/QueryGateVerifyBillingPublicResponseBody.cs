// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyBillingPublicResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   If OK is returned, the request is successful.
        /// *   For more information about other error codes, see [API response codes](~~85198~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The billing information about each verification service.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGateVerifyBillingPublicResponseBodyData Data { get; set; }
        public class QueryGateVerifyBillingPublicResponseBodyData : TeaModel {
            /// <summary>
            /// The fees generated for all verification services. Unitrogen: CNY.
            /// </summary>
            [NameInMap("AmountSum")]
            [Validation(Required=false)]
            public string AmountSum { get; set; }

            /// <summary>
            /// The details of fees.
            /// </summary>
            [NameInMap("SceneBillingList")]
            [Validation(Required=false)]
            public List<QueryGateVerifyBillingPublicResponseBodyDataSceneBillingList> SceneBillingList { get; set; }
            public class QueryGateVerifyBillingPublicResponseBodyDataSceneBillingList : TeaModel {
                /// <summary>
                /// The billable items.
                /// </summary>
                [NameInMap("Add")]
                [Validation(Required=false)]
                public string Add { get; set; }

                /// <summary>
                /// The fees generated for the verification service. Unitrogen: CNY.
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// The application name.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The verification method.
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// The service code.
                /// </summary>
                [NameInMap("SceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                /// <summary>
                /// The service name.
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// The unit price. Unit: CNY.
                /// </summary>
                [NameInMap("SinglePrice")]
                [Validation(Required=false)]
                public string SinglePrice { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
