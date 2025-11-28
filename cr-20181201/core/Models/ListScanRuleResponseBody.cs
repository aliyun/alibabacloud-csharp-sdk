// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
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

        [NameInMap("ScanRules")]
        [Validation(Required=false)]
        public List<ListScanRuleResponseBodyScanRules> ScanRules { get; set; }
        public class ListScanRuleResponseBodyScanRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1702361810000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

            [NameInMap("RepoNames")]
            [Validation(Required=false)]
            public List<string> RepoNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>.*</para>
            /// </summary>
            [NameInMap("RepoTagFilterPattern")]
            [Validation(Required=false)]
            public string RepoTagFilterPattern { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cicd-prod</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crscnr-2sdveqjhpzd****</para>
            /// </summary>
            [NameInMap("ScanRuleId")]
            [Validation(Required=false)]
            public string ScanRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>REPO</para>
            /// </summary>
            [NameInMap("ScanScope")]
            [Validation(Required=false)]
            public string ScanScope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SBOM</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTO</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1764122725000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
