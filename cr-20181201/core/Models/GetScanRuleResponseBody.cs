// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetScanRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C87993B5-7D61-5CAC-8D64-1AC732DD69FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScanRule")]
        [Validation(Required=false)]
        public GetScanRuleResponseBodyScanRule ScanRule { get; set; }
        public class GetScanRuleResponseBodyScanRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-03-15T17:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cri-szw6f6bhrky0c8jk</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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
            /// <para>protection</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crscnr-aemytkwad2h7fyhb</para>
            /// </summary>
            [NameInMap("ScanRuleId")]
            [Validation(Required=false)]
            public string ScanRuleId { get; set; }

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
            /// <para>2025-08-28T20:07:33.164</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
