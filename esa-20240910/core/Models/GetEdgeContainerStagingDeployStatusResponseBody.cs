// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerStagingDeployStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the container status is ready. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ok</b>: Ready.</para>
        /// </description></item>
        /// <item><description><para><b>unready</b>: Not ready.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("ContainersReady")]
        [Validation(Required=false)]
        public string ContainersReady { get; set; }

        /// <summary>
        /// <para>The creation time (UNIX timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-24T06:46:35Z</para>
        /// </summary>
        [NameInMap("CreationTimestamp")]
        [Validation(Required=false)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// <para>The container initialization status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ok</b>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>unready</b>: Not completed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public string Initialized { get; set; }

        /// <summary>
        /// <para>The status of the container in the staging environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoContainer: no container.</description></item>
        /// <item><description>Pending: pending deployment.</description></item>
        /// <item><description>ContainerCreating: the container is being created.</description></item>
        /// <item><description>Running: running.</description></item>
        /// <item><description>Succeeded: completed.</description></item>
        /// <item><description>ImagePullBackOff: image pull failed.</description></item>
        /// <item><description>CrashLoopBackOff: abnormal container startup.</description></item>
        /// <item><description>Failed: failed.</description></item>
        /// <item><description>Unknown: unknown.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The container restart status.</para>
        /// </summary>
        [NameInMap("PodRestartState")]
        [Validation(Required=false)]
        public GetEdgeContainerStagingDeployStatusResponseBodyPodRestartState PodRestartState { get; set; }
        public class GetEdgeContainerStagingDeployStatusResponseBodyPodRestartState : TeaModel {
            /// <summary>
            /// <para>The reason for the last restart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OOMKilled</para>
            /// </summary>
            [NameInMap("LastTerminatedReason")]
            [Validation(Required=false)]
            public string LastTerminatedReason { get; set; }

            /// <summary>
            /// <para>The number of restarts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RestartCount")]
            [Validation(Required=false)]
            public int? RestartCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the container is ready to receive traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ok</b>: Ready.</para>
        /// </description></item>
        /// <item><description><para><b>unready</b>: Not ready.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public string Ready { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F2C992B-3FE2-5EBB-A61F-F9DD4EB257DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The container scheduling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ok</b>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>unready</b>: Not completed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Scheduled")]
        [Validation(Required=false)]
        public string Scheduled { get; set; }

        /// <summary>
        /// <para>The list of VIPs.</para>
        /// </summary>
        [NameInMap("VIPs")]
        [Validation(Required=false)]
        public List<string> VIPs { get; set; }

    }

}
