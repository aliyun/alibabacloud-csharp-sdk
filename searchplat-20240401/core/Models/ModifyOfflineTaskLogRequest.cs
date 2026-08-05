// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ModifyOfflineTaskLogRequest : TeaModel {
        /// <summary>
        /// <para>The network configuration for enabling or disabling network access.</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public ModifyOfflineTaskLogRequestNetwork Network { get; set; }
        public class ModifyOfflineTaskLogRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The ES private network information.</para>
            /// </summary>
            [NameInMap("privateEs")]
            [Validation(Required=false)]
            public ModifyOfflineTaskLogRequestNetworkPrivateEs PrivateEs { get; set; }
            public class ModifyOfflineTaskLogRequestNetworkPrivateEs : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable or disable private network access.</para>
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
                public List<ModifyOfflineTaskLogRequestNetworkPrivateEsWhiteIpGroup> WhiteIpGroup { get; set; }
                public class ModifyOfflineTaskLogRequestNetworkPrivateEsWhiteIpGroup : TeaModel {
                    /// <summary>
                    /// <para>The name of the IP whitelist group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kevintest</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The IP whitelist.</para>
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

            }

            /// <summary>
            /// <para><b>The ES public network information.</b></para>
            /// </summary>
            [NameInMap("publicEs")]
            [Validation(Required=false)]
            public ModifyOfflineTaskLogRequestNetworkPublicEs PublicEs { get; set; }
            public class ModifyOfflineTaskLogRequestNetworkPublicEs : TeaModel {
                /// <summary>
                /// <para><b>Specifies whether to enable or disable public network access.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para><b>The IP whitelist group information.</b></para>
                /// </summary>
                [NameInMap("whiteIpGroup")]
                [Validation(Required=false)]
                public List<ModifyOfflineTaskLogRequestNetworkPublicEsWhiteIpGroup> WhiteIpGroup { get; set; }
                public class ModifyOfflineTaskLogRequestNetworkPublicEsWhiteIpGroup : TeaModel {
                    /// <summary>
                    /// <para><b>The name of the IP whitelist group.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kevintest</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para><b>The IP whitelist.</b></para>
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
