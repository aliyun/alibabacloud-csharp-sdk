// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerGetConnectionResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerGetConnectionResponseBodyData Data { get; set; }
        public class OnsConsumerGetConnectionResponseBodyData : TeaModel {
            /// <summary>
            /// The client connection information of the consumer group.
            /// </summary>
            [NameInMap("ConnectionList")]
            [Validation(Required=false)]
            public OnsConsumerGetConnectionResponseBodyDataConnectionList ConnectionList { get; set; }
            public class OnsConsumerGetConnectionResponseBodyDataConnectionList : TeaModel {
                [NameInMap("ConnectionDo")]
                [Validation(Required=false)]
                public List<OnsConsumerGetConnectionResponseBodyDataConnectionListConnectionDo> ConnectionDo { get; set; }
                public class OnsConsumerGetConnectionResponseBodyDataConnectionListConnectionDo : TeaModel {
                    /// <summary>
                    /// The IP address and port number of the consumer client.
                    /// </summary>
                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    /// <summary>
                    /// The ID of the consumer client.
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// The programming language in which the consumer application was developed.
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// The version of the consumer client.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
