// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePackTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compliance pack template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-5f26ff4e06a300c4****</para>
        /// </summary>
        [NameInMap("CompliancePackTemplateId")]
        [Validation(Required=false)]
        public string CompliancePackTemplateId { get; set; }

        /// <summary>
        /// <para>The field used to filter the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LAW</para>
        /// </summary>
        [NameInMap("FilterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource type that is evaluated by the rules. If you specify this parameter, only the compliance pack templates that contain rules for the specified resource type are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>The risk level of the rules in the compliance pack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: high</description></item>
        /// <item><description>2: medium</description></item>
        /// <item><description>3: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RuleRiskLevel")]
        [Validation(Required=false)]
        public int? RuleRiskLevel { get; set; }

    }

}
