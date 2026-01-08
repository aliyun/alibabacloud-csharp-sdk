// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdatePrivateNetwrokRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdatePrivateNetwrokRequestBody> Body { get; set; }
        public class UpdatePrivateNetwrokRequestBody : TeaModel {
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
            /// <para>ep-bp1id6dc2568****</para>
            /// </summary>
            [NameInMap("pvlEndpointId")]
            [Validation(Required=false)]
            public string PvlEndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRIVATE_ES</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-uf664nyle5khp5***</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("whiteIpGroup")]
            [Validation(Required=false)]
            public List<UpdatePrivateNetwrokRequestBodyWhiteIpGroup> WhiteIpGroup { get; set; }
            public class UpdatePrivateNetwrokRequestBodyWhiteIpGroup : TeaModel {
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
