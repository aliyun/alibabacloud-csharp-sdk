// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawSkillTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. This parameter is required. If this parameter is not provided, an InvalidApplicationId.Malformed (HTTP 400) error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// <remarks>
        /// <para>If you are calling this operation for the first time, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_polarclaw</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to view all available regions for the current account, including region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of the skill template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill template for test.</para>
        /// </summary>
        [NameInMap("SkillTemplateDesc")]
        [Validation(Required=false)]
        public string SkillTemplateDesc { get; set; }

        /// <summary>
        /// <para>The name of the skill template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill_template_test</para>
        /// </summary>
        [NameInMap("SkillTemplateName")]
        [Validation(Required=false)]
        public string SkillTemplateName { get; set; }

        /// <summary>
        /// <para>The skill template parameters. Specify a standard JSON object string with the skill identifier as the key, such as {&quot;skill1&quot;:{&quot;skillName&quot;:&quot;polarclawhub&quot;,&quot;version&quot;:&quot;0.0.0&quot;}}. JSON arrays or single-quote formats are not accepted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;skill1&quot;:{&quot;skillName&quot;:&quot;polarclawhub&quot;,&quot;version&quot;:&quot;0.0.0&quot;}}</para>
        /// </summary>
        [NameInMap("SkillTemplateParam")]
        [Validation(Required=false)]
        public string SkillTemplateParam { get; set; }

    }

}
