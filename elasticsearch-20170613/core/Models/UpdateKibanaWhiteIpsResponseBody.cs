// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaWhiteIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Elasticsearch cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5EF11F1-DBAE-4020-AC24-DFA6C4345CAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The private IP address whitelists for access to the Kibana console of the cluster.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateKibanaWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateKibanaWhiteIpsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The public IP address whitelists for access to the Kibana console of the cluster.</para>
            /// </summary>
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            /// <summary>
            /// <para>The private IP address whitelists for access to the Kibana console of the cluster.</para>
            /// </summary>
            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public UpdateKibanaWhiteIpsResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class UpdateKibanaWhiteIpsResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The IP address whitelists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1jy348ibzulk6hn****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1a0mifpletdd1da****</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <para>The IP address whitelists.</para>
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<UpdateKibanaWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class UpdateKibanaWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// <para>The IP addresses in the whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_group_name</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The IP addresses in the whitelist.</para>
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PUBLIC_KIBANA</para>
                    /// </summary>
                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

        }

    }

}
