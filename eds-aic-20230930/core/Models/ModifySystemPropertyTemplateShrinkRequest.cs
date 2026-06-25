// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifySystemPropertyTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically generate preset system properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAuto")]
        [Validation(Required=false)]
        public bool? EnableAuto { get; set; }

        /// <summary>
        /// <para>The URL of the property template file. The system synchronously parses the file. If the file format is invalid, a parsing error is returned.</para>
        /// <remarks>
        /// <para>File template format: <c>{ &quot;properties&quot;:{&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;:&quot;value2&quot;}}</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://filepath****.com">https://filepath****.com</a></para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The information about the system property template.</para>
        /// </summary>
        [NameInMap("SystemPropertyInfo")]
        [Validation(Required=false)]
        public string SystemPropertyInfoShrink { get; set; }

        /// <summary>
        /// <para>The ID of the property template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-angyvganxlf****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template 1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
