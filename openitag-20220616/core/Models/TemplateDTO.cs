// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateDTO : TeaModel {
        /// <summary>
        /// <para>Template categorization</para>
        /// 
        /// <b>Example:</b>
        /// <para>picture</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>Template description</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Template additional information</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>List of question widget configurations</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("QuestionConfigs")]
        [Validation(Required=false)]
        public List<QuestionPlugin> QuestionConfigs { get; set; }

        /// <summary>
        /// <para>List of assisted annotation configurations</para>
        /// </summary>
        [NameInMap("RobotConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> RobotConfigs { get; set; }

        /// <summary>
        /// <para>Template shared mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharedMode")]
        [Validation(Required=false)]
        public string SharedMode { get; set; }

        /// <summary>
        /// <para>List of tag information</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>Template ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1529***48342353920</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Template Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>View layer configuration</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ViewConfigs")]
        [Validation(Required=false)]
        public TemplateDTOViewConfigs ViewConfigs { get; set; }
        public class TemplateDTOViewConfigs : TeaModel {
            /// <summary>
            /// <para>List of view widgets</para>
            /// </summary>
            [NameInMap("ViewPlugins")]
            [Validation(Required=false)]
            public List<ViewPlugin> ViewPlugins { get; set; }

        }

    }

}
