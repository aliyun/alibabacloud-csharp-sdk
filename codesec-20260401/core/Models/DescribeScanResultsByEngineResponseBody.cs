// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScanResultsByEngineResponseBody : TeaModel {
        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sast</description></item>
        /// <item><description>sca</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The result list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeScanResultsByEngineResponseBodyItems> Items { get; set; }
        public class DescribeScanResultsByEngineResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Filters results by incremental scan baseline status. Valid values: new, unchanged, absent, updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new</para>
            /// </summary>
            [NameInMap("baselineState")]
            [Validation(Required=false)]
            public string BaselineState { get; set; }

            /// <summary>
            /// <para>The category. The system classifies files based on file name extensions and MIME types. Common categories include doc, image, audio, and video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL Injection</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The code snippet near the primary location (SAST).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("codeSnippet")]
            [Validation(Required=false)]
            public string CodeSnippet { get; set; }

            /// <summary>
            /// <para>The rule confidence level, ranging from 0 to 1. This field is common in SAST results and is omitted if not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("confidence")]
            [Validation(Required=false)]
            public double? Confidence { get; set; }

            /// <summary>
            /// <para>The time when the finding record was created (RFC 3339 format).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The associated CWE ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CWE-601</para>
            /// </summary>
            [NameInMap("cweId")]
            [Validation(Required=false)]
            public string CweId { get; set; }

            /// <summary>
            /// <para>The issue description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User input is directly concatenated into an SQL statement, which may lead to SQL injection.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The end line number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("endLine")]
            [Validation(Required=false)]
            public long? EndLine { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aone2/2247063/1767838276141/Artifacts_EBookingApps_Pipeline_V2_Staging_131.tgz</para>
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>934</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The brief summary of the finding. Unlike description, this field is more of a conclusion statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User input is used to construct SQL queries without sanitization</para>
            /// </summary>
            [NameInMap("itemSummary")]
            [Validation(Required=false)]
            public string ItemSummary { get; set; }

            /// <summary>
            /// <para>The OWASP category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A01:2021-Broken Access Control</para>
            /// </summary>
            [NameInMap("owaspCategory")]
            [Validation(Required=false)]
            public string OwaspCategory { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdp2cdl_cdp_sha_nprd</para>
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The remediation code example.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String sql = \&quot;SELECT * FROM users WHERE name = ?\&quot;;\nPreparedStatement ps = conn.prepareStatement(sql);\nps.setString(1, username);\nResultSet rs = ps.executeQuery();</para>
            /// </summary>
            [NameInMap("remediationCodeExample")]
            [Validation(Required=false)]
            public string RemediationCodeExample { get; set; }

            /// <summary>
            /// <para>The remediation suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Use PreparedStatement with parameterized queries instead of string concatenation</para>
            /// </summary>
            [NameInMap("remediationSuggestion")]
            [Validation(Required=false)]
            public string RemediationSuggestion { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java-sqli-001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The SCA component information. This field is returned only when engine is set to sca.</para>
            /// </summary>
            [NameInMap("scaComponent")]
            [Validation(Required=false)]
            public DescribeScanResultsByEngineResponseBodyItemsScaComponent ScaComponent { get; set; }
            public class DescribeScanResultsByEngineResponseBodyItemsScaComponent : TeaModel {
                /// <summary>
                /// <para>The number of CVEs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cveCount")]
                [Validation(Required=false)]
                public long? CveCount { get; set; }

                /// <summary>
                /// <para>The list of CVE details associated with a component in the SCA finding.</para>
                /// </summary>
                [NameInMap("cveDetails")]
                [Validation(Required=false)]
                public List<DescribeScanResultsByEngineResponseBodyItemsScaComponentCveDetails> CveDetails { get; set; }
                public class DescribeScanResultsByEngineResponseBodyItemsScaComponentCveDetails : TeaModel {
                    /// <summary>
                    /// <para>The associated CWE ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CVE-2021-44228</para>
                    /// </summary>
                    [NameInMap("cveId")]
                    [Validation(Required=false)]
                    public string CveId { get; set; }

                    /// <summary>
                    /// <para>The CVSS score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("cvss")]
                    [Validation(Required=false)]
                    public double? Cvss { get; set; }

                    /// <summary>
                    /// <para>The CVSS version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v2.0</para>
                    /// </summary>
                    [NameInMap("cvssVersion")]
                    [Validation(Required=false)]
                    public string CvssVersion { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Apache Log4j2 JNDI features do not protect against attacker-controlled LDAP and other JNDI-related endpoints.</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The reference information.</para>
                    /// </summary>
                    [NameInMap("references")]
                    [Validation(Required=false)]
                    public List<string> References { get; set; }

                    /// <summary>
                    /// <para>The severity level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>critical</description></item>
                    /// <item><description>high</description></item>
                    /// <item><description>medium</description></item>
                    /// <item><description>low</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>critical</para>
                    /// </summary>
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                }

                /// <summary>
                /// <para>The list of dependency introduction paths in the SCA component information. This field is returned only when engine is set to sca.</para>
                /// </summary>
                [NameInMap("introPaths")]
                [Validation(Required=false)]
                public List<string> IntroPaths { get; set; }

                /// <summary>
                /// <para>Indicates whether the component is a direct dependency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isDirect")]
                [Validation(Required=false)]
                public bool? IsDirect { get; set; }

                /// <summary>
                /// <para>The component coordinate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org.apache.logging.log4j:log4j-core</para>
                /// </summary>
                [NameInMap("packageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                /// <summary>
                /// <para>The component-level remediation suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Upgrade log4j-core to version 2.17.1 or later</para>
                /// </summary>
                [NameInMap("remediation")]
                [Validation(Required=false)]
                public string Remediation { get; set; }

                /// <summary>
                /// <para>The component version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.14.1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3176</para>
            /// </summary>
            [NameInMap("scanId")]
            [Validation(Required=false)]
            public long? ScanId { get; set; }

            /// <summary>
            /// <para>The severity level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>critical </description></item>
            /// <item><description>high </description></item>
            /// <item><description>medium </description></item>
            /// <item><description>low</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>todo_open_dingoj06pvqfeayy3lkr</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The start line number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("startLine")]
            [Validation(Required=false)]
            public long? StartLine { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: Running.</description></item>
            /// <item><description>completed: Completed.</description></item>
            /// <item><description>failed: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The SAST taint analysis call chain that describes the complete propagation path of sensitive data from the taint source to the dangerous sink. This field is returned only when engine is set to sast.</para>
            /// </summary>
            [NameInMap("taintFlow")]
            [Validation(Required=false)]
            public List<DescribeScanResultsByEngineResponseBodyItemsTaintFlow> TaintFlow { get; set; }
            public class DescribeScanResultsByEngineResponseBodyItemsTaintFlow : TeaModel {
                /// <summary>
                /// <para>The code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stmt.executeQuery(sql);</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>src/main/java/com/example/UserService.java</para>
                /// </summary>
                [NameInMap("file")]
                [Validation(Required=false)]
                public string File { get; set; }

                /// <summary>
                /// <para>The role type in the taint propagation chain. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>source: taint source.</description></item>
                /// <item><description>propagator: propagation node.	</description></item>
                /// <item><description>validation: validation or scrubbing center.	</description></item>
                /// <item><description>sink: dangerous sink.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>source</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The line number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("line")]
                [Validation(Required=false)]
                public int? Line { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sink: SQL query executed</para>
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The step number, starting from 0 and incrementing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            /// <summary>
            /// <para>The text summary of the taint call chain. This field is returned only when engine is set to sast.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User input flows from HTTP parameter into SQL query executio</para>
            /// </summary>
            [NameInMap("taintFlowSummary")]
            [Validation(Required=false)]
            public string TaintFlowSummary { get; set; }

            /// <summary>
            /// <para>The issue title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL Injection Risk</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not pass nextToken or pass an empty string for the first page. To retrieve the next page, pass the nextToken value from the previous response without any modification. When the nextToken in the response is empty, you have reached the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ0IjoiMjAyNi0wNy0xNlQwNzo1MzozOC4wMjFaIiwiaSI6MTAwMDQ0OH0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76851f2b5bf0187fbc29e8bca4</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3088795</para>
        /// </summary>
        [NameInMap("scanId")]
        [Validation(Required=false)]
        public long? ScanId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
