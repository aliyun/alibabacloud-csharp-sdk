// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateDetail : TeaModel {
        /// <summary>
        /// <para>Reasons for deprecation.</para>
        /// </summary>
        [NameInMap("AbandonReasons")]
        [Validation(Required=false)]
        public List<string> AbandonReasons { get; set; }

        /// <summary>
        /// <para>Template categorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>picture</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>Creator.</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        /// <summary>
        /// <para>Template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Additional template information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>Creation Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-07 16:09:20</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Updated At.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-07 16:09:20</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Modifier.</para>
        /// </summary>
        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public SimpleUser Modifier { get; set; }

        /// <summary>
        /// <para>Question widget configuration.</para>
        /// </summary>
        [NameInMap("QuestionConfigs")]
        [Validation(Required=false)]
        public List<QuestionPlugin> QuestionConfigs { get; set; }

        /// <summary>
        /// <para>Template shared mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharedMode")]
        [Validation(Required=false)]
        public string SharedMode { get; set; }

        /// <summary>
        /// <para>Template status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Label information.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>Template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1529***48342353920</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Template Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Tenant where the template resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA***W134</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>Template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>picture</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>View layer configuration.</para>
        /// </summary>
        [NameInMap("ViewConfigs")]
        [Validation(Required=false)]
        public TemplateDetailViewConfigs ViewConfigs { get; set; }
        public class TemplateDetailViewConfigs : TeaModel {
            /// <summary>
            /// <para>View widgets.</para>
            /// </summary>
            [NameInMap("ViewPlugins")]
            [Validation(Required=false)]
            public List<ViewPlugin> ViewPlugins { get; set; }

        }

    }

}
