// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetScanRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Return value</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful, valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The API call was successful</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The API call failed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C87993B5-7D61-5CAC-8D64-1AC732DD69FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scan rule.</para>
        /// </summary>
        [NameInMap("ScanRule")]
        [Validation(Required=false)]
        public GetScanRuleResponseBodyScanRule ScanRule { get; set; }
        public class GetScanRuleResponseBodyScanRule : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-03-15T17:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-szw6f6bhrky0c8jk</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Names of namespaces where the event is effective.</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

            /// <summary>
            /// <para>Names of repositories where the event is effective.</para>
            /// </summary>
            [NameInMap("RepoNames")]
            [Validation(Required=false)]
            public List<string> RepoNames { get; set; }

            /// <summary>
            /// <para>Tag filter pattern for event triggering.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.*</para>
            /// </summary>
            [NameInMap("RepoTagFilterPattern")]
            [Validation(Required=false)]
            public string RepoTagFilterPattern { get; set; }

            /// <summary>
            /// <para>The event rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>protection</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The scan rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crscnr-aemytkwad2h7fyhb</para>
            /// </summary>
            [NameInMap("ScanRuleId")]
            [Validation(Required=false)]
            public string ScanRuleId { get; set; }

            /// <summary>
            /// <para>The scan scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REPO</para>
            /// </summary>
            [NameInMap("ScanScope")]
            [Validation(Required=false)]
            public string ScanScope { get; set; }

            /// <summary>
            /// <para>The vulnerability type: </para>
            /// <list type="bullet">
            /// <item><description><para><c>cve</c>: System vulnerability</para>
            /// </description></item>
            /// <item><description><para><c>sca</c>: Application vulnerability</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SBOM</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The trigger type, valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ALL</c>: All triggers</para>
            /// </description></item>
            /// <item><description><para><c>TAG_LISTTAG</c>: Trigger</para>
            /// </description></item>
            /// <item><description><para><c>TAG_REG_EXP</c>: Expression trigger</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T20:07:33.164</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
