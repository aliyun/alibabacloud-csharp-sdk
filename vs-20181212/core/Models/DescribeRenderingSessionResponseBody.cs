// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>Additional optional ingress network information</para>
        /// </summary>
        [NameInMap("AdditionalIngresses")]
        [Validation(Required=false)]
        public List<DescribeRenderingSessionResponseBodyAdditionalIngresses> AdditionalIngresses { get; set; }
        public class DescribeRenderingSessionResponseBodyAdditionalIngresses : TeaModel {
            /// <summary>
            /// <para>Domain name or IP address of the cloud application service instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>111.45.29.96</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Carrier code. Valid values:</para>
            /// <ol>
            /// <item><description><para>cmcc</para>
            /// </description></item>
            /// <item><description><para>unicom</para>
            /// </description></item>
            /// <item><description><para>telecom</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>unicom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>List of port mappings</para>
            /// </summary>
            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeRenderingSessionResponseBodyAdditionalIngressesPortMappings> PortMappings { get; set; }
            public class DescribeRenderingSessionResponseBodyAdditionalIngressesPortMappings : TeaModel {
                /// <summary>
                /// <para>Public port or port range, such as 22. For a port range, use a forward slash (/) to separate the start and end ports. Example: 10/20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11060/11079</para>
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// <para>Private port or port range. Each private port maps one-to-one with a public port. For a port range, use a forward slash (/) to separate the start and end ports. Example: 10/20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11060/11079</para>
                /// </summary>
                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

            }

        }

        /// <summary>
        /// <para>Cloud application ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>End client ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>c91263a0-f9ac-45bd-bbe9-6e293ad32d91</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>Instance hostname. Defaults to the EIP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111.45.29.96</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Carrier code. Valid values:</para>
        /// <ol>
        /// <item><description><para>cmcc</para>
        /// </description></item>
        /// <item><description><para>unicom</para>
        /// </description></item>
        /// <item><description><para>telecom</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>Cloud application service instance location</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public DescribeRenderingSessionResponseBodyLocation Location { get; set; }
        public class DescribeRenderingSessionResponseBodyLocation : TeaModel {
            /// <summary>
            /// <para>Province code of the cloud application service instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>310000</para>
            /// </summary>
            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        /// <summary>
        /// <para>Cloud application patch package ID. An empty value means the original version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>Port mapping information</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingSessionResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingSessionResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>Public port or port range, such as 22. For a port range, use a forward slash (/) to separate the start and end ports. Example: 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>Private port or port range. Each private port maps one-to-one with a public port. For a port range, use a forward slash (/) to separate the start and end ports. Example: 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <para>Cloud application service instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-i205217481741918129226</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-18T02:20:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Session state information</para>
        /// </summary>
        [NameInMap("StateInfo")]
        [Validation(Required=false)]
        public DescribeRenderingSessionResponseBodyStateInfo StateInfo { get; set; }
        public class DescribeRenderingSessionResponseBodyStateInfo : TeaModel {
            /// <summary>
            /// <para>State description</para>
            /// 
            /// <b>Example:</b>
            /// <para>已启动</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Session state. Valid values:</para>
            /// <ol>
            /// <item><description><para>SessionStarting: Starting the session</para>
            /// </description></item>
            /// <item><description><para>SessionStartSuspended: Session start is suspended. Retry by calling Start again.</para>
            /// </description></item>
            /// <item><description><para>SessionStarted: Session started or in use</para>
            /// </description></item>
            /// <item><description><para>SessionStartFailed: Session failed to start</para>
            /// </description></item>
            /// <item><description><para>SessionAbnormal: Session became abnormal after starting successfully</para>
            /// </description></item>
            /// <item><description><para>SessionStopping: Stopping the session</para>
            /// </description></item>
            /// <item><description><para>SessionStopFailed: Session failed to stop</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>SessionStarted</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Time when the state was last updated</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-15T10:05:20+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
