// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawSkillTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("SkillTemplates")]
        [Validation(Required=false)]
        public List<DescribePolarClawSkillTemplatesResponseBodySkillTemplates> SkillTemplates { get; set; }
        public class DescribePolarClawSkillTemplatesResponseBodySkillTemplates : TeaModel {
            /// <summary>
            /// <para>The time when the skill template was created. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-15T16:00Z</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>423</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the skill template was last modified. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-16T16:00Z</para>
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// <para>The number of skills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SkillCounts")]
            [Validation(Required=false)]
            public string SkillCounts { get; set; }

            /// <summary>
            /// <para>The skill template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill template for test</para>
            /// </summary>
            [NameInMap("SkillTemplateDesc")]
            [Validation(Required=false)]
            public string SkillTemplateDesc { get; set; }

            /// <summary>
            /// <para>The skill template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcpg-skill-2ze5v8n27o7x92a</para>
            /// </summary>
            [NameInMap("SkillTemplateId")]
            [Validation(Required=false)]
            public string SkillTemplateId { get; set; }

            /// <summary>
            /// <para>The skill template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-template-test</para>
            /// </summary>
            [NameInMap("SkillTemplateName")]
            [Validation(Required=false)]
            public string SkillTemplateName { get; set; }

            /// <summary>
            /// <para>The skill templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: System template.</description></item>
            /// <item><description>1: User template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SkillTemplateType")]
            [Validation(Required=false)]
            public string SkillTemplateType { get; set; }

            /// <summary>
            /// <para>The source application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-**************</para>
            /// </summary>
            [NameInMap("SrcApplicationId")]
            [Validation(Required=false)]
            public string SrcApplicationId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries. This parameter is returned only for list queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
