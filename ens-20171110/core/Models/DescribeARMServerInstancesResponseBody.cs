// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the servers and the AIC instances.</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<DescribeARMServerInstancesResponseBodyServers> Servers { get; set; }
        public class DescribeARMServerInstancesResponseBodyServers : TeaModel {
            /// <summary>
            /// <para>The information about the AIC instances.</para>
            /// </summary>
            [NameInMap("AICInstances")]
            [Validation(Required=false)]
            public List<DescribeARMServerInstancesResponseBodyServersAICInstances> AICInstances { get; set; }
            public class DescribeARMServerInstancesResponseBodyServersAICInstances : TeaModel {
                /// <summary>
                /// <para>The refresh rate of the AIC instance. Unit: Hz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public long? Frequency { get; set; }

                /// <summary>
                /// <para>The ID of the AIC image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The ID of the AIC instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aic-instance****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The operation that was most recently performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ServerCreate</para>
                /// </summary>
                [NameInMap("LatestAction")]
                [Validation(Required=false)]
                public string LatestAction { get; set; }

                /// <summary>
                /// <para>The name of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AIC-Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network attributes of the AIC instance.</para>
                /// </summary>
                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeARMServerInstancesResponseBodyServersAICInstancesNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeARMServerInstancesResponseBodyServersAICInstancesNetworkAttributes : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the AIC instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.XX.XX</para>
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    /// <summary>
                    /// <para>The network ID of the AIC instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>n-*****</para>
                    /// </summary>
                    [NameInMap("NetworkId")]
                    [Validation(Required=false)]
                    public string NetworkId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID of the AIC instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-****</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The resolution of the AIC instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1920*1080</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                /// <summary>
                /// <para>The information about the shared data group (SDG) that is deployed on the AIC instance.</para>
                /// </summary>
                [NameInMap("SdgDeployInfo")]
                [Validation(Required=false)]
                public DescribeARMServerInstancesResponseBodyServersAICInstancesSdgDeployInfo SdgDeployInfo { get; set; }
                public class DescribeARMServerInstancesResponseBodyServersAICInstancesSdgDeployInfo : TeaModel {
                    /// <summary>
                    /// <para>The ID of the SDG.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sdg-xxxxx</para>
                    /// </summary>
                    [NameInMap("SDGId")]
                    [Validation(Required=false)]
                    public string SDGId { get; set; }

                    /// <summary>
                    /// <para>The deployment status of the SDG. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>sdg_deploying</b></description></item>
                    /// <item><description><b>failed</b></description></item>
                    /// <item><description><b>success</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The specification of the AIC instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aic.cf53r.c2.np</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The operation status of the AIC instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b></description></item>
                /// <item><description><b>failed</b></description></item>
                /// <item><description><b>creating</b></description></item>
                /// <item><description><b>releasing</b></description></item>
                /// <item><description><b>rebooting</b></description></item>
                /// <item><description><b>reseting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The running status of the AIC instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>running</b></description></item>
                /// <item><description><b>pending</b></description></item>
                /// <item><description><b>terminating</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-07 11:59:09</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou-27</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-05-07 11:59:09</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The operation that was most recently performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ServerCreate</para>
            /// </summary>
            [NameInMap("LatestAction")]
            [Validation(Required=false)]
            public string LatestAction { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Server-Name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace of the cluster to which the server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepay</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-******</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The server specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas.cf53r</para>
            /// </summary>
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            /// <summary>
            /// <para>The operation status of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>creating</b></description></item>
            /// <item><description><b>releasing</b></description></item>
            /// <item><description><b>rebooting</b></description></item>
            /// <item><description><b>upgrading</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The running status of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>stopping</b></description></item>
            /// <item><description><b>down</b></description></item>
            /// <item><description><b>starting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
