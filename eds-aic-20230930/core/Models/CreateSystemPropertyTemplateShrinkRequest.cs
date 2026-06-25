// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateSystemPropertyTemplateShrinkRequest : TeaModel {
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
        /// <para>The URL of the property template file. The API parses the file synchronously. An error is returned if the file format is invalid.</para>
        /// <remarks>
        /// <para>The file must be in the following format: <c>{ &quot;properties&quot;:{&quot;key1&quot;:&quot;value1&quot;}}</c>.</para>
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
        /// <para>The name of the template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Be 2 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Start with an uppercase or lowercase letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>Contain letters, digits, colons (:), underscores (_), and hyphens (-). Periods (.) are not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Template1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
