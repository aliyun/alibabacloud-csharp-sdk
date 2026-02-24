// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListManagedRulesRequest : TeaModel {
        /// <summary>
        /// <para>The scope of the filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>托管规则筛选范围，可以筛选无资源覆盖的托管规则。取值：</para>
        /// <list type="bullet">
        /// <item><description>ALL 全部</description></item>
        /// <item><description>UNCOVERED_RESOURCE 筛选有资源未覆盖的托管规则</description></item>
        /// </list>
        /// </summary>
        [NameInMap("FilterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <para>The keyword of the rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDN</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>The value must be greater than or equal to 1. Default value: 1.</para>
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
        /// <para>The resource type that is evaluated by the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>The risk level of the rule template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: high</para>
        /// </description></item>
        /// <item><description><para>2: medium</para>
        /// </description></item>
        /// <item><description><para>3: low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

    }

}
