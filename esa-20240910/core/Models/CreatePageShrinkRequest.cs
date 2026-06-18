// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreatePageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The page content, which must be provided in BASE64 encoding. For example, the value PGh0bWw+aGVsbG8gcGFnZTwvaHRtbD4= decodes to \<html>hello page\</html>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PGh0bWw+aGVsbG8gcGFnZTwvaHRtbD4=</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The <c>Content-Type</c> HTTP header. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>text/html</para>
        /// </description></item>
        /// <item><description><para>application/json</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text/html</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The description of the page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom deny page</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the custom error page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public string SiteIdsShrink { get; set; }

    }

}
