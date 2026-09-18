// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class ListJobPlansShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter by template association. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns only scenario-specific job plans that have a template.</description></item>
        /// <item><description>false: Returns only general-purpose job plans that do not have a template.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, no filtering is applied. If both this parameter and TemplateId are specified, the value of TemplateId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasTemplate")]
        [Validation(Required=false)]
        public bool? HasTemplate { get; set; }

        /// <summary>
        /// <para>The name of the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JobPlan1</para>
        /// </summary>
        [NameInMap("JobPlanName")]
        [Validation(Required=false)]
        public string JobPlanName { get; set; }

        /// <summary>
        /// <para>The type of the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Distillation</para>
        /// </summary>
        [NameInMap("JobPlanType")]
        [Validation(Required=false)]
        public string JobPlanType { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>The distillation template ID. Filters results to return only scenario-specific tasks that use the specified template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32495</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
