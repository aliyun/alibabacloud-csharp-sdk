// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerGetConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerGetConnectionResponseBodyData Data { get; set; }
        public class OnsConsumerGetConnectionResponseBodyData : TeaModel {
            [NameInMap("ConnectionList")]
            [Validation(Required=false)]
            public OnsConsumerGetConnectionResponseBodyDataConnectionList ConnectionList { get; set; }
            public class OnsConsumerGetConnectionResponseBodyDataConnectionList : TeaModel {
                [NameInMap("ConnectionDo")]
                [Validation(Required=false)]
                public List<OnsConsumerGetConnectionResponseBodyDataConnectionListConnectionDo> ConnectionDo { get; set; }
                public class OnsConsumerGetConnectionResponseBodyDataConnectionListConnectionDo : TeaModel {
                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            [NameInMap("MessageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE4140C7-F42D-473D-A5FF-B1E31692****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
