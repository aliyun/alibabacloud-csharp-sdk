// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The updated description of the list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the custom list. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850217.html">ListLists</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The updated items in the list. The value is a JSON array string, such as <c>[&quot;1.1.1.1&quot;,&quot;2.2.2.2&quot;]</c>.</para>
        /// <para><b>Full overwrite semantics</b>: The specified <c>Items</c> completely overwrites the original list content instead of appending to it.</para>
        /// <remarks>
        /// <para>⚠️ <b>If this parameter is not specified or is left empty, the original list content is cleared</b>. To retain the original items and append new ones, call <c>GetList</c> to retrieve the existing <c>Items</c>, concatenate them, and submit them at once.</para>
        /// </remarks>
        /// <para><b>Element format</b>: The format depends on the <c>Kind</c> specified when the list was created. UpdateList does not support modifying the kind.</para>
        /// <list type="bullet">
        /// <item><description>Kind = <c>ip</c>: Each element must be a valid IP address or CIDR block. If an element is invalid, <c>WrongValueMatched</c> is returned.</description></item>
        /// <item><description>Other kinds: The element format is subject to conventions, and the number of elements is limited by the tenant quota <c>NumberItemsPerList</c>. Only the <c>ip</c> kind is not subject to this limit.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public string ItemsShrink { get; set; }

        /// <summary>
        /// <para>The updated name of the custom list. If this parameter is not specified, the original name is retained.</para>
        /// <para><b>Naming rules</b>: Only letters, digits, and underscores are supported. The regular expression is <c>^\\w{1,64}$</c>, and the length is 1 to 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
