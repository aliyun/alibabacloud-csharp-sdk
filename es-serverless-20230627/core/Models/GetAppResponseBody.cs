// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAppResponseBodyResult Result { get; set; }
        public class GetAppResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-app-abc</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-severless-test-app</para>
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-15T11:20:52.370Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-15T11:21:50.000Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("network")]
            [Validation(Required=false)]
            public List<GetAppResponseBodyResultNetwork> Network { get; set; }
            public class GetAppResponseBodyResultNetwork : TeaModel {
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("whiteIpGroup")]
                [Validation(Required=false)]
                public List<GetAppResponseBodyResultNetworkWhiteIpGroup> WhiteIpGroup { get; set; }
                public class GetAppResponseBodyResultNetworkWhiteIpGroup : TeaModel {
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>*******7595</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("privateNetwork")]
            [Validation(Required=false)]
            public List<GetAppResponseBodyResultPrivateNetwork> PrivateNetwork { get; set; }
            public class GetAppResponseBodyResultPrivateNetwork : TeaModel {
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("pvlEndpointId")]
                [Validation(Required=false)]
                public string PvlEndpointId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("whiteIpGroup")]
                [Validation(Required=false)]
                public List<GetAppResponseBodyResultPrivateNetworkWhiteIpGroup> WhiteIpGroup { get; set; }
                public class GetAppResponseBodyResultPrivateNetworkWhiteIpGroup : TeaModel {
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.10</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
