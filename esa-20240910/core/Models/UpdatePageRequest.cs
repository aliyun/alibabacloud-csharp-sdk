// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdatePageRequest : TeaModel {
        /// <summary>
        /// <para>The BASE64-encoded page content, which must be consistent with <c>ContentType</c>.</para>
        /// <para><b>Encoding method</b>:</para>
        /// <ol>
        /// <item><description>Convert the original page content to a UTF-8 byte string.</description></item>
        /// <item><description>Encode the byte string using standard BASE64 encoding.</description></item>
        /// </ol>
        /// <para><b>Example</b>: <c>&lt;html&gt;hello page&lt;/html&gt;</c> → <c>PGh0bWw+aGVsbG8gcGFnZTwvaHRtbD4=</c></para>
        /// <remarks>
        /// <para>The maximum size limit is subject to the server-side custom page specification. If this parameter is not specified, the original page content is retained.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PGh0bWw+aGVsbG8gcGFnZTwvaHRtbD4=</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The MIME type of the page content, which is returned to the client as the HTTP <c>Content-Type</c> response header when a rule is matched.</para>
        /// <para><b>Common values</b>:</para>
        /// <list type="bullet">
        /// <item><description><c>text/html</c>: HTML page</description></item>
        /// <item><description><c>application/json</c>: JSON response</description></item>
        /// </list>
        /// <remarks>
        /// <para>The complete set of supported values is subject to the server-side specification. The actual format of <c>Content</c> must match this field. A mismatch may cause browser rendering issues.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text/html</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The description of the page after the update. This is used to identify the purpose of the page in the console list. This is an optional field. If this parameter is not specified, the original description is retained. The maximum field length is subject to the server-side limit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom deny page</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the custom response page. You can obtain this value by calling the <a href="https://help.aliyun.com/document_detail/2850223.html">ListPages</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the custom response page after the update.</para>
        /// <para><b>Naming suggestion</b>: Use a combination of letters, digits, and underscores (such as <c>blocked_page_v2</c>) for easy reference in rules. The character set, maximum length, and uniqueness constraints are subject to the server-side naming conventions for custom pages. If this parameter is not specified, the original name is retained.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of site IDs associated with this page after the update. This parameter uses full overwrite semantics.</para>
        /// <list type="bullet">
        /// <item><description>You can obtain site IDs by calling the <c>ListSites</c> operation.</description></item>
        /// <item><description>Passing an empty list dissociates all sites from the page.</description></item>
        /// <item><description>Including a site ID that does not belong to your account returns an <c>InvalidParameter</c> error.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public List<long?> SiteIds { get; set; }

    }

}
