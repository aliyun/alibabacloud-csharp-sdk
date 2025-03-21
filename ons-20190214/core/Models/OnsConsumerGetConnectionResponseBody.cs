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
            /// <summary>
            /// <para>The client connection information of the consumer group.</para>
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
                    /// <para>The IP address and port number of the consumer client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30.5.121.**</para>
                    /// </summary>
                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30.5.121.**@24813#-1999745829#-1737591554#453111174894656</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The programming language in which the consumer application was developed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JAVA</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// <para>The version of the consumer client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V4_3_6</para>
                    /// </summary>
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
