// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CB62B5E-605B-5A23-9110-728B8207A25C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scan rules.</para>
        /// </summary>
        [NameInMap("ScanRules")]
        [Validation(Required=false)]
        public List<ListScanRuleResponseBodyScanRules> ScanRules { get; set; }
        public class ListScanRuleResponseBodyScanRules : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1702361810000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of namespaces.</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// </summary>
            [NameInMap("RepoNames")]
            [Validation(Required=false)]
            public List<string> RepoNames { get; set; }

            /// <summary>
            /// <para>The tag that triggers the scan matches the regular expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.*</para>
            /// </summary>
            [NameInMap("RepoTagFilterPattern")]
            [Validation(Required=false)]
            public string RepoTagFilterPattern { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cicd-prod</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The scan rule id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crscnr-2sdveqjhpzd****</para>
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
            /// <para>The scan type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>VUL</c>: Products Cloud Security Scanner</description></item>
            /// <item><description><c>SBOM</c>: Product Content Analysis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SBOM</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The trigger type.</para>
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
            /// <para>1764122725000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
