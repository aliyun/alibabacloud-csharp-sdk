// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata of the template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public CreateTemplateResponseBodyTemplate Template { get; set; }
        public class CreateTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The creator of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(13090000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Describe instances of given status</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the template was configured with a trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasTrigger")]
            [Validation(Required=false)]
            public bool? HasTrigger { get; set; }

            /// <summary>
            /// <para>The SHA-256 value of the template content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4bc7d7a21b3e003434b9c223f6e6d2578b5ebfeb5be28c1fcf8a8a1b11907bb4</para>
            /// </summary>
            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The share type of the template. The share type of the template that you create is Private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The tags of the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{     &quot;k1&quot;:&quot;v1&quot;,     &quot;k2&quot;:&quot;v2&quot; }</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The format of the template. The system automatically determines whether the format is JSON or YAML.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSON</para>
            /// </summary>
            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-94753d38</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyTemplate</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The version of the template. The name of the version consists of the letter v and a number. The number starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that last modified the information about the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <para>The type of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
