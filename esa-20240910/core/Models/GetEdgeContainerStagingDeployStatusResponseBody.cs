// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerStagingDeployStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the container is ready.</para>
        /// <list type="bullet">
        /// <item><description>ok</description></item>
        /// <item><description>unready</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("ContainersReady")]
        [Validation(Required=false)]
        public string ContainersReady { get; set; }

        /// <summary>
        /// <para>The time when the container was created. The value is a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-24T06:46:35Z</para>
        /// </summary>
        [NameInMap("CreationTimestamp")]
        [Validation(Required=false)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// <para>The initialization status of the container.</para>
        /// <list type="bullet">
        /// <item><description>ok</description></item>
        /// <item><description>unready</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public string Initialized { get; set; }

        /// <summary>
        /// <para>The status of the container in the staging environment.</para>
        /// <list type="bullet">
        /// <item><description>NoContainer: created.</description></item>
        /// <item><description>Running: running.</description></item>
        /// <item><description>Failed: abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The details of container restart.</para>
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
            /// <para>The number of times that the container restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RestartCount")]
            [Validation(Required=false)]
            public int? RestartCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether domain names are associated with the container.</para>
        /// <list type="bullet">
        /// <item><description>ok</description></item>
        /// <item><description>unready</description></item>
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
        /// <para>The scheduling status of the container.</para>
        /// <list type="bullet">
        /// <item><description>ok</description></item>
        /// <item><description>unready</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Scheduled")]
        [Validation(Required=false)]
        public string Scheduled { get; set; }

        /// <summary>
        /// <para>The virtual IP addresses.</para>
        /// </summary>
        [NameInMap("VIPs")]
        [Validation(Required=false)]
        public List<string> VIPs { get; set; }

    }

}
