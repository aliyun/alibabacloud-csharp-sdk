// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductTopicResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The list of topic categories returned if the call is successful. For more information, see **ProductTopicInfo**.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductTopicResponseBodyData Data { get; set; }
        public class QueryProductTopicResponseBodyData : TeaModel {
            [NameInMap("ProductTopicInfo")]
            [Validation(Required=false)]
            public List<QueryProductTopicResponseBodyDataProductTopicInfo> ProductTopicInfo { get; set; }
            public class QueryProductTopicResponseBodyDataProductTopicInfo : TeaModel {
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// The description of the topic category.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("EnableProxySubscribe")]
                [Validation(Required=false)]
                public bool? EnableProxySubscribe { get; set; }

                /// <summary>
                /// The ID of the topic category.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The operation that devices can perform on the topic category. Valid values:
                /// 
                /// *   **0**: Publish.
                /// *   **1**: Subscribe.
                /// *   **2**: Publish and Subscribe.
                /// </summary>
                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                /// <summary>
                /// The ProductKey of the product.
                /// </summary>
                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                /// <summary>
                /// The topic category that does not include the \_productKey\_ and \_deviceName\_ levels.
                /// </summary>
                [NameInMap("TopicShortName")]
                [Validation(Required=false)]
                public string TopicShortName { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
