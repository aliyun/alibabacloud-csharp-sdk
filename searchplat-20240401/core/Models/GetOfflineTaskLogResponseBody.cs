// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetOfflineTaskLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1-2-3-4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetOfflineTaskLogResponseBodyResult Result { get; set; }
        public class GetOfflineTaskLogResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The network information.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public GetOfflineTaskLogResponseBodyResultNetwork Network { get; set; }
            public class GetOfflineTaskLogResponseBodyResultNetwork : TeaModel {
                /// <summary>
                /// <para>The private ES information.</para>
                /// </summary>
                [NameInMap("privateEs")]
                [Validation(Required=false)]
                public GetOfflineTaskLogResponseBodyResultNetworkPrivateEs PrivateEs { get; set; }
                public class GetOfflineTaskLogResponseBodyResultNetworkPrivateEs : TeaModel {
                    /// <summary>
                    /// <para>The domain name of the private ES.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test.private.cn-hangzhou.log.elasticsearch.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>Indicates whether private ES is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The IP whitelist groups.</para>
                    /// </summary>
                    [NameInMap("whiteIpGroup")]
                    [Validation(Required=false)]
                    public List<GetOfflineTaskLogResponseBodyResultNetworkPrivateEsWhiteIpGroup> WhiteIpGroup { get; set; }
                    public class GetOfflineTaskLogResponseBodyResultNetworkPrivateEsWhiteIpGroup : TeaModel {
                        /// <summary>
                        /// <para>The group name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>kevintest</para>
                        /// </summary>
                        [NameInMap("groupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>The list of IP addresses in the whitelist group.</para>
                        /// </summary>
                        [NameInMap("ips")]
                        [Validation(Required=false)]
                        public List<string> Ips { get; set; }

                    }

                }

                /// <summary>
                /// <para>The public ES information.</para>
                /// </summary>
                [NameInMap("publicEs")]
                [Validation(Required=false)]
                public GetOfflineTaskLogResponseBodyResultNetworkPublicEs PublicEs { get; set; }
                public class GetOfflineTaskLogResponseBodyResultNetworkPublicEs : TeaModel {
                    /// <summary>
                    /// <para>The public domain name of ES.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test.public.cn-hangzhou.log.elasticsearch.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>Indicates whether public ES is enabled.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The IP whitelist groups.</para>
                    /// </summary>
                    [NameInMap("whiteIpGroup")]
                    [Validation(Required=false)]
                    public List<GetOfflineTaskLogResponseBodyResultNetworkPublicEsWhiteIpGroup> WhiteIpGroup { get; set; }
                    public class GetOfflineTaskLogResponseBodyResultNetworkPublicEsWhiteIpGroup : TeaModel {
                        /// <summary>
                        /// <para>The group name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>kevintest</para>
                        /// </summary>
                        [NameInMap("groupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>The list of IP addresses in the whitelist group.</para>
                        /// </summary>
                        [NameInMap("ips")]
                        [Validation(Required=false)]
                        public List<string> Ips { get; set; }

                    }

                }

            }

        }

    }

}
