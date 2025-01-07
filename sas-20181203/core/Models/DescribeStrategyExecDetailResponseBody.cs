// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyExecDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the baseline check ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-05 00:12:46</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of check items that failed to pass the baseline check. This type of check item is considered risk items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// <para>The servers on which risk items were detected.</para>
        /// </summary>
        [NameInMap("FailedEcsList")]
        [Validation(Required=false)]
        public List<DescribeStrategyExecDetailResponseBodyFailedEcsList> FailedEcsList { get; set; }
        public class DescribeStrategyExecDetailResponseBodyFailedEcsList : TeaModel {
            /// <summary>
            /// <para>The IP address of the server on which the baseline check was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115.28.XX.XX</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-k8s-for-cs-cf5741fb95c3a45d0864f0e4544dc****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115.28.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.31.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The failure cause for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Detect timeout</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>The number of tasks that are **running **based on the baseline check policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InProcessCount")]
        [Validation(Required=false)]
        public int? InProcessCount { get; set; }

        /// <summary>
        /// <para>The execution progress of the baseline check policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100%</para>
        /// </summary>
        [NameInMap("Percent")]
        [Validation(Required=false)]
        public string Percent { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01611D72-1E33-53F5-A9A5-C81B5561970F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the baseline check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Schedule</b>: automatic check that periodically runs</description></item>
        /// <item><description><b>Manual</b>: intermediate check that is manually performed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The time when the baseline check starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-05 00:12:16</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The number of check items that <b>passed</b> the baseline check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
