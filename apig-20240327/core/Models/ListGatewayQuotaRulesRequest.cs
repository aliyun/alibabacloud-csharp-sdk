// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayQuotaRulesRequest : TeaModel {
        /// <summary>
        /// <para>The keyword in the rule name used for fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single call. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4tM8BlBJwHSNyjWpGaci4/7dKNGp1JMgsKtvCagmtY=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values: enabled and disabled. If you do not specify this parameter, all rules are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ruleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>The keyword in the name of the associated subject for fuzzy matching based on the consumer or consumer group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alpha</para>
        /// </summary>
        [NameInMap("subjectNameLike")]
        [Validation(Required=false)]
        public string SubjectNameLike { get; set; }

    }

}
