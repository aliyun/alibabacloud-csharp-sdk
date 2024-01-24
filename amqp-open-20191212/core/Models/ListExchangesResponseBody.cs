// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangesResponseBodyData Data { get; set; }
        public class ListExchangesResponseBodyData : TeaModel {
            /// <summary>
            /// The exchanges.
            /// </summary>
            [NameInMap("Exchanges")]
            [Validation(Required=false)]
            public List<ListExchangesResponseBodyDataExchanges> Exchanges { get; set; }
            public class ListExchangesResponseBodyDataExchanges : TeaModel {
                /// <summary>
                /// The attributes. This parameter is unavailable in the current version.
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                /// <summary>
                /// Indicates whether the exchange was automatically deleted.
                /// </summary>
                [NameInMap("AutoDeleteState")]
                [Validation(Required=false)]
                public bool? AutoDeleteState { get; set; }

                /// <summary>
                /// The timestamp that indicates when the exchange was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The exchange type.
                /// </summary>
                [NameInMap("ExchangeType")]
                [Validation(Required=false)]
                public string ExchangeType { get; set; }

                /// <summary>
                /// The exchange name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The vhost name.
                /// </summary>
                [NameInMap("VHostName")]
                [Validation(Required=false)]
                public string VHostName { get; set; }

            }

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that marks the end of the current returned page.``
            /// 
            /// *   If the value of this parameter is empty, the next query is not required and the token used to start the next query is unavailable.``
            /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.``
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
