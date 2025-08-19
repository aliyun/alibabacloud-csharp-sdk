// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateNetworkRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateNetworkRequestBody> Body { get; set; }
        public class UpdateNetworkRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>autotest-8k8a8.serverless.cn-hangzhou.elasticsearch.aliyuncs.com</para>
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
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLIC_ES</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("whiteIpGroup")]
            [Validation(Required=false)]
            public List<UpdateNetworkRequestBodyWhiteIpGroup> WhiteIpGroup { get; set; }
            public class UpdateNetworkRequestBodyWhiteIpGroup : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>Cover</para>
                /// </summary>
                [NameInMap("modifyMode")]
                [Validation(Required=false)]
                public string ModifyMode { get; set; }

            }

        }

    }

}
