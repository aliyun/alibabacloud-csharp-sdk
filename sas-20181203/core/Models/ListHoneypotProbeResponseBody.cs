// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of honeypot probe data.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotProbeResponseBodyList> List { get; set; }
        public class ListHoneypotProbeResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The management node data.</para>
            /// </summary>
            [NameInMap("ControlNode")]
            [Validation(Required=false)]
            public ListHoneypotProbeResponseBodyListControlNode ControlNode { get; set; }
            public class ListHoneypotProbeResponseBodyListControlNode : TeaModel {
                /// <summary>
                /// <para>The ECS instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf6eq0rlvu1mkh0p****</para>
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ec9da17-c0e7-4642-aad6-defc9722****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HoneypotNode1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// <para>The deployment time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669363825000</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public long? DeployTime { get; set; }

            /// <summary>
            /// <para>The probe name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-pinpoint-hd1b</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The local IP address bound to the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33.53.XX.XX</para>
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// <para>The operating system type of the probe instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: Windows.</description></item>
            /// <item><description>linux: Linux.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The probe ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4d167bb3-dd09-4a6a-a179-d5d6a5b0****</para>
            /// </summary>
            [NameInMap("ProbeId")]
            [Validation(Required=false)]
            public string ProbeId { get; set; }

            /// <summary>
            /// <para>The probe type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host_probe</b>: host probe</description></item>
            /// <item><description><b>vpc_black_hole_probe</b>: VPC blackhole probe.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>host_probe</para>
            /// </summary>
            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            /// <summary>
            /// <para>The probe version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18060096</para>
            /// </summary>
            [NameInMap("ProbeVersion")]
            [Validation(Required=false)]
            public string ProbeVersion { get; set; }

            /// <summary>
            /// <para>The probe status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>installed</b>: Installation succeeded.</description></item>
            /// <item><description><b>install_failed</b>: Installation failed.</description></item>
            /// <item><description><b>online</b>: Normal.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>unnormal</b>: Service exception.</description></item>
            /// <item><description><b>unprobe</b>: Unauthorized.</description></item>
            /// <item><description><b>uninstalling</b>: Uninstalling.</description></item>
            /// <item><description><b>uninstalled</b>: Uninstallation succeeded.</description></item>
            /// <item><description><b>uninstall_failed</b>: Uninstallation failed.</description></item>
            /// <item><description><b>not_exist</b>: Not installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance where the host probe is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the VPC-connected instance where the VPC probe is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-5gu8iu68w9b472jbb****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotProbeResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotProbeResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of honeypot probes displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number returned in the paged query during paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of honeypot probes displayed per page in the paged query during paging. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of honeypot probes returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4BC9E610-21BE-537F-82EF-144A60D5A970</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
