// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateNetworkResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<UpdateNetworkResponseBodyResult> Result { get; set; }
        public class UpdateNetworkResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-123.serverless.cn-hangzhou.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLIC_ES</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("whiteIpGroup")]
            [Validation(Required=false)]
            public List<UpdateNetworkResponseBodyResultWhiteIpGroup> WhiteIpGroup { get; set; }
            public class UpdateNetworkResponseBodyResultWhiteIpGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

            }

        }

    }

}
