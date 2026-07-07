// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreatePageRequest : TeaModel {
        /// <summary>
        /// <para>The BASE64-encoded page content. The actual content format must match the value of <c>ContentType</c>.</para>
        /// <para><b>Encoding method</b>:</para>
        /// <ol>
        /// <item><description>Encode the original page content into a byte string by using UTF-8 encoding.</description></item>
        /// <item><description>Apply standard BASE64 encoding to the byte string.</description></item>
        /// </ol>
        /// <para><b>Example</b>:</para>
        /// <list type="bullet">
        /// <item><description>Original content: <c>&lt;html&gt;hello page&lt;/html&gt;</c></description></item>
        /// <item><description>BASE64: <c>PGh0bWw+aGVsbG8gcGFnZTwvaHRtbD4=</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>The maximum size, supported character sets, and security filtering rules are subject to the server-side custom page specifications.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PGh0bWw+aGVsbG8gcGFnZTwvaHRtbD4=</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The MIME type of the page content. This value is returned to the client as the HTTP <c>Content-Type</c> response header after a match.</para>
        /// <para><b>Common values</b>:</para>
        /// <list type="bullet">
        /// <item><description><c>text/html</c>: HTML page. The <c>Content</c> parameter must be set to the BASE64-encoded value of UTF-8 HTML text.</description></item>
        /// <item><description><c>application/json</c>: JSON response. The <c>Content</c> parameter must be set to the BASE64-encoded value of a valid JSON string.</description></item>
        /// <item><description><c>text/plain</c>: plain text. The <c>Content</c> parameter must be set to the BASE64-encoded value of plain text content.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: The complete list of supported ContentType values is subject to the server-side specifications. If the specified <c>ContentType</c> does not match the actual format of <c>Content</c>, the client may fail to render the page properly.</para>
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
        /// <para>The description of the page, used to identify the purpose of the page in the console list.</para>
        /// <para><b>Suggested content</b>: Use the scenarios and identity information of the page, such as &quot;CC protection block page - Chinese version&quot;. This is an optional field. If not specified, the value is empty by default.</para>
        /// <remarks>
        /// <para>The maximum field length is subject to the server-side specifications.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a custom deny page</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the custom page.</para>
        /// <para><b>Naming suggestions</b>: Use a short name that consists of letters, digits, and underscores, such as <c>blocked_page_v1</c>, for easy reference in rules. The specific character set, maximum length, uniqueness, and other constraints are <b>subject to the server-side custom page naming specifications</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of website IDs to associate with this custom page.</para>
        /// <list type="bullet">
        /// <item><description>You can obtain website IDs by calling the <c>ListSites</c> operation.</description></item>
        /// <item><description>If you pass an empty list (no websites are associated), the page is still created but does not take effect. You can call the <c>UpdatePage</c> operation later to associate websites.</description></item>
        /// <item><description>If the list contains a website ID that does not belong to the current account, an <c>InvalidParameter</c> error is returned.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public List<long?> SiteIds { get; set; }

    }

}
