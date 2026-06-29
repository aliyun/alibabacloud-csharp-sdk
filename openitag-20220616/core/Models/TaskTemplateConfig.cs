// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskTemplateConfig : TeaModel {
        /// <summary>
        /// <para>Additional information for template configuration.</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, string> Exif { get; set; }

        /// <summary>
        /// <para>Display field corresponding to the View.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("ResourceKey")]
        [Validation(Required=false)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// <para>List of questions in the template.</para>
        /// </summary>
        [NameInMap("SelectQuestions")]
        [Validation(Required=false)]
        public List<string> SelectQuestions { get; set; }

        /// <summary>
        /// <para>Template options configuration.</para>
        /// </summary>
        [NameInMap("TemplateOptionMap")]
        [Validation(Required=false)]
        public Dictionary<string, TaskTemplateOptionConfig> TemplateOptionMap { get; set; }

        /// <summary>
        /// <para>Template ID on which this depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>154***2391839854592</para>
        /// </summary>
        [NameInMap("TemplateRelationId")]
        [Validation(Required=false)]
        public string TemplateRelationId { get; set; }

    }

}
