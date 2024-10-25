// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServcieScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The index number of the scheduled virtual device (pod).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5myukg7hnpbto7m024002****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.26.XX.XX</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The start port of the scheduled instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// <para>The summary information about the scheduled virtual device.</para>
        /// </summary>
        [NameInMap("PodAbstractInfo")]
        [Validation(Required=false)]
        public DescribeServcieScheduleResponseBodyPodAbstractInfo PodAbstractInfo { get; set; }
        public class DescribeServcieScheduleResponseBodyPodAbstractInfo : TeaModel {
            /// <summary>
            /// <para>The name of the container service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("ContainerService")]
            [Validation(Required=false)]
            public bool? ContainerService { get; set; }

            /// <summary>
            /// <para>The information about the container.</para>
            /// </summary>
            [NameInMap("ContainerStatuses")]
            [Validation(Required=false)]
            public DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatuses ContainerStatuses { get; set; }
            public class DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatuses : TeaModel {
                [NameInMap("ContainerStatus")]
                [Validation(Required=false)]
                public List<DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatusesContainerStatus> ContainerStatus { get; set; }
                public class DescribeServcieScheduleResponseBodyPodAbstractInfoContainerStatusesContainerStatus : TeaModel {
                    /// <summary>
                    /// <para>The ID of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>container_e79_1638372147094_158091_02_000001</para>
                    /// </summary>
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    /// <summary>
                    /// <para>The name of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nginx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gcs-prod-websocket-eip-telecom</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public bool? Name { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-aliyun</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public bool? Namespace { get; set; }

            /// <summary>
            /// <para>The pod scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FDN</para>
            /// </summary>
            [NameInMap("ResourceScope")]
            [Validation(Required=false)]
            public bool? ResourceScope { get; set; }

            /// <summary>
            /// <para>The status of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is repeated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public bool? RequestRepeated { get; set; }

        /// <summary>
        /// <para>The TCP port range of the scheduled instance or container. The value is in the ${from}-$-{to} format. Example: 80-88.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80-88</para>
        /// </summary>
        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public string TcpPorts { get; set; }

    }

}
