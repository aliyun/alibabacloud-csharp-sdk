// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The additional optional ingress network information.</para>
        /// </summary>
        [NameInMap("AdditionalIngresses")]
        [Validation(Required=false)]
        public List<DescribeRenderingSessionResponseBodyAdditionalIngresses> AdditionalIngresses { get; set; }
        public class DescribeRenderingSessionResponseBodyAdditionalIngresses : TeaModel {
            /// <summary>
            /// <para>The domain name or IP address of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111.45.29.96</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The ISP code. Valid values:</para>
            /// <ol>
            /// <item><description>cmcc</description></item>
            /// <item><description>unicom</description></item>
            /// <item><description>telecom</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>unicom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The port mapping list.</para>
            /// </summary>
            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeRenderingSessionResponseBodyAdditionalIngressesPortMappings> PortMappings { get; set; }
            public class DescribeRenderingSessionResponseBodyAdditionalIngressesPortMappings : TeaModel {
                /// <summary>
                /// <para>The external port or port range, such as 22. For a port range, separate the start and end ports with a forward slash (/), for example, 10/20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11060/11079</para>
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// <para>The internal port or port range. The internal ports correspond one-to-one to the external ports. For a port range, separate the start and end ports with a forward slash (/), for example, 10/20.</para>
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
        /// <para>The cloud application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The client ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c91263a0-f9ac-45bd-bbe9-6e293ad32d91</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The instance hostname. By default, the value is the elastic IP address (EIP) used for access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111.45.29.96</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The ISP code. Valid values:</para>
        /// <ol>
        /// <item><description>cmcc</description></item>
        /// <item><description>unicom</description></item>
        /// <item><description>telecom</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The location information of the cloud application service instance.</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public DescribeRenderingSessionResponseBodyLocation Location { get; set; }
        public class DescribeRenderingSessionResponseBodyLocation : TeaModel {
            /// <summary>
            /// <para>The province code of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>310000</para>
            /// </summary>
            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        /// <summary>
        /// <para>The cloud application patch package ID. An empty value indicates the original version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The port mapping information.</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingSessionResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingSessionResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>The external port or port range, such as 22. For a port range, separate the start and end ports with a forward slash (/), for example, 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>The internal port or port range. The internal ports correspond one-to-one to the external ports. For a port range, separate the start and end ports with a forward slash (/), for example, 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <para>The cloud application service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-i205217481741918129226</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The start time. The time is in UTC and follows the ISO 8601 standard. The format is YYYY-MM-DDTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-18T02:20:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The session status information.</para>
        /// </summary>
        [NameInMap("StateInfo")]
        [Validation(Required=false)]
        public DescribeRenderingSessionResponseBodyStateInfo StateInfo { get; set; }
        public class DescribeRenderingSessionResponseBodyStateInfo : TeaModel {
            /// <summary>
            /// <para>The status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Started</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The session status. Valid values:</para>
            /// <ol>
            /// <item><description>SessionStarting: The session is starting.</description></item>
            /// <item><description>SessionStartSuspended: The session start is suspended. You can initiate start again to retry.</description></item>
            /// <item><description>SessionStarted: The session is started or in use.</description></item>
            /// <item><description>SessionStartFailed: The session failed to start.</description></item>
            /// <item><description>SessionAbnormal: The session is abnormal after a successful start.</description></item>
            /// <item><description>SessionStopping: The session is stopping.</description></item>
            /// <item><description>SessionStopFailed: The session failed to stop.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>SessionStarted</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the status was last updated. The time follows the ISO 8601 standard and includes the time zone offset. The format is YYYY-MM-DDTHH:mm:ss+HH:mm.</para>
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
