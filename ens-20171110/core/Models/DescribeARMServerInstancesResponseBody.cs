// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the servers and the AIC instances.
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<DescribeARMServerInstancesResponseBodyServers> Servers { get; set; }
        public class DescribeARMServerInstancesResponseBodyServers : TeaModel {
            /// <summary>
            /// The information about the AIC instances.
            /// </summary>
            [NameInMap("AICInstances")]
            [Validation(Required=false)]
            public List<DescribeARMServerInstancesResponseBodyServersAICInstances> AICInstances { get; set; }
            public class DescribeARMServerInstancesResponseBodyServersAICInstances : TeaModel {
                /// <summary>
                /// The refresh rate of the AIC instance. Unit: Hz.
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public long? Frequency { get; set; }

                /// <summary>
                /// The ID of the AIC image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The ID of the AIC instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The operation that was most recently performed.
                /// </summary>
                [NameInMap("LatestAction")]
                [Validation(Required=false)]
                public string LatestAction { get; set; }

                /// <summary>
                /// The name of the container.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The network attributes of the AIC instance.
                /// </summary>
                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeARMServerInstancesResponseBodyServersAICInstancesNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeARMServerInstancesResponseBodyServersAICInstancesNetworkAttributes : TeaModel {
                    /// <summary>
                    /// The IP address of the AIC instance.
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    /// <summary>
                    /// The network ID of the AIC instance.
                    /// </summary>
                    [NameInMap("NetworkId")]
                    [Validation(Required=false)]
                    public string NetworkId { get; set; }

                    /// <summary>
                    /// The vSwitch ID of the AIC instance.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// The resolution of the AIC instance.
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                /// <summary>
                /// The information about the shared data group (SDG) that is deployed on the AIC instance.
                /// </summary>
                [NameInMap("SdgDeployInfo")]
                [Validation(Required=false)]
                public DescribeARMServerInstancesResponseBodyServersAICInstancesSdgDeployInfo SdgDeployInfo { get; set; }
                public class DescribeARMServerInstancesResponseBodyServersAICInstancesSdgDeployInfo : TeaModel {
                    /// <summary>
                    /// The ID of the SDG.
                    /// </summary>
                    [NameInMap("SDGId")]
                    [Validation(Required=false)]
                    public string SDGId { get; set; }

                    /// <summary>
                    /// The deployment status of the SDG. Valid values:
                    /// 
                    /// *   **sdg_deploying**
                    /// *   **failed**
                    /// *   **success**
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The specification of the AIC instance.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The operation status of the AIC instance. Valid values:
                /// 
                /// *   **success**
                /// *   **failed**
                /// *   **creating**
                /// *   **releasing**
                /// *   **rebooting**
                /// *   **reseting**
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The running status of the AIC instance. Valid values:
                /// 
                /// *   **running**
                /// *   **pending**
                /// *   **terminating**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the ENS node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The time when the instance expires.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The operation that was most recently performed.
            /// </summary>
            [NameInMap("LatestAction")]
            [Validation(Required=false)]
            public string LatestAction { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace of the cluster to which the server belongs.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The billing method.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// The server specification.
            /// </summary>
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            /// <summary>
            /// The operation status of the server. Valid values:
            /// 
            /// *   **success**
            /// *   **failed**
            /// *   **creating**
            /// *   **releasing**
            /// *   **rebooting**
            /// *   **upgrading**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The running status of the server. Valid values:
            /// 
            /// *   **running**
            /// *   **stopping**
            /// *   **down**
            /// *   **starting**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
