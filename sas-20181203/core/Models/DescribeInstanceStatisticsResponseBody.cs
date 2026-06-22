// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics information of asset risks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyData> Data { get; set; }
        public class DescribeInstanceStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of unusual logon events on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public int? Account { get; set; }

            /// <summary>
            /// <para>The number of security alerts detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("AgentlessAll")]
            [Validation(Required=false)]
            public int? AgentlessAll { get; set; }

            /// <summary>
            /// <para>The number of baseline issues detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AgentlessBaseline")]
            [Validation(Required=false)]
            public int? AgentlessBaseline { get; set; }

            /// <summary>
            /// <para>The number of malicious samples detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AgentlessMalicious")]
            [Validation(Required=false)]
            public int? AgentlessMalicious { get; set; }

            /// <summary>
            /// <para>The number of sensitive file alerts detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentlessSensitiveFile")]
            [Validation(Required=false)]
            public int? AgentlessSensitiveFile { get; set; }

            /// <summary>
            /// <para>The number of system vulnerabilities detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentlessVulCve")]
            [Validation(Required=false)]
            public int? AgentlessVulCve { get; set; }

            /// <summary>
            /// <para>The number of application vulnerabilities detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentlessVulSca")]
            [Validation(Required=false)]
            public int? AgentlessVulSca { get; set; }

            /// <summary>
            /// <para>The number of Windows system vulnerabilities detected by agentless detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentlessVulSys")]
            [Validation(Required=false)]
            public int? AgentlessVulSys { get; set; }

            /// <summary>
            /// <para>The number of application vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppNum")]
            [Validation(Required=false)]
            public int? AppNum { get; set; }

            /// <summary>
            /// <para>The number of Web-CMS vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CmsNum")]
            [Validation(Required=false)]
            public int? CmsNum { get; set; }

            /// <summary>
            /// <para>The number of high-risk CSPM issues on the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CspmHighRiskNum")]
            [Validation(Required=false)]
            public string CspmHighRiskNum { get; set; }

            /// <summary>
            /// <para>The number of Cloud Security Posture Management (CSPM) risk issues on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CspmNum")]
            [Validation(Required=false)]
            public int? CspmNum { get; set; }

            /// <summary>
            /// <para>The number of common vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CveNum")]
            [Validation(Required=false)]
            public int? CveNum { get; set; }

            /// <summary>
            /// <para>The number of urgent vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("EmgNum")]
            [Validation(Required=false)]
            public int? EmgNum { get; set; }

            /// <summary>
            /// <para>The number of baseline risk issues on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Health")]
            [Validation(Required=false)]
            public int? Health { get; set; }

            /// <summary>
            /// <para>The number of reminder-level security alerts on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemindSuspiciousNum")]
            [Validation(Required=false)]
            public string RemindSuspiciousNum { get; set; }

            /// <summary>
            /// <para>The number of middleware vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaNum")]
            [Validation(Required=false)]
            public int? ScaNum { get; set; }

            /// <summary>
            /// <para>The number of high-risk security alerts on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SeriousSuspiciousNum")]
            [Validation(Required=false)]
            public string SeriousSuspiciousNum { get; set; }

            /// <summary>
            /// <para>The number of suspicious security alerts on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuspectSuspiciousNum")]
            [Validation(Required=false)]
            public string SuspectSuspiciousNum { get; set; }

            /// <summary>
            /// <para>The number of security alerts on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

            /// <summary>
            /// <para>The number of system vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SysAsapVulCount")]
            [Validation(Required=false)]
            public string SysAsapVulCount { get; set; }

            /// <summary>
            /// <para>The number of Windows system vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SysNum")]
            [Validation(Required=false)]
            public int? SysNum { get; set; }

            /// <summary>
            /// <para>The number of trojans detected on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Trojan")]
            [Validation(Required=false)]
            public int? Trojan { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The total number of vulnerabilities on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }

            /// <summary>
            /// <para>The number of weak passwords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("WeakPWNum")]
            [Validation(Required=false)]
            public int? WeakPWNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F035A9D-D19F-5430-8CA5-1497991B7C61</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
