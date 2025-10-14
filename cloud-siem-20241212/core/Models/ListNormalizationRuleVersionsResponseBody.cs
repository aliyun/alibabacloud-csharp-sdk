// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationRuleVersionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50。</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****。</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("NormalizationRuleVersions")]
        [Validation(Required=false)]
        public List<ListNormalizationRuleVersionsResponseBodyNormalizationRuleVersions> NormalizationRuleVersions { get; set; }
        public class ListNormalizationRuleVersionsResponseBodyNormalizationRuleVersions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>| pack-fields -include=\&quot;[\s\S]+\&quot; as extend_content。</description></item>
            /// </list>
            /// </summary>
            [NameInMap("NormalizationRuleExpression")]
            [Validation(Required=false)]
            public string NormalizationRuleExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nr-z0b2ssjteut85uoh9nzp。</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>V1。</para>
            /// </summary>
            [NameInMap("NormalizationRuleVersion")]
            [Validation(Required=false)]
            public int? NormalizationRuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57。</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
