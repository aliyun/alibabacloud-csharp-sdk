// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the list.</para>
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
        /// <para>The new list content. The value is a JSON array string, for example, <c>[&quot;1.1.1.1&quot;,&quot;2.2.2.2&quot;]</c>.</para>
        /// <para><b>Full overwrite semantics</b>: The specified <c>Items</c> value completely overwrites the existing list content instead of appending to it.</para>
        /// <remarks>
        /// <para>⚠️ <b>If this parameter is not specified or is set to an empty value, the existing list content is cleared</b>. To retain existing items and append new ones, call <c>GetList</c> to retrieve the current <c>Items</c>, merge them, and then submit the combined list.</para>
        /// </remarks>
        /// <para><b>Element format</b>: The format depends on the <c>Kind</c> value specified when the list was created. UpdateList does not support modifying Kind.</para>
        /// <list type="bullet">
        /// <item><description>Kind = <c>ip</c>: Each element must be a valid IP address or CIDR block. If an element is invalid, <c>WrongValueMatched</c> is returned.</description></item>
        /// <item><description>Other Kind values: The element format is subject to the relevant specifications. The number of elements is limited by the tenant quota <c>NumberItemsPerList</c>. This limit does not apply to the <c>ip</c> Kind.</description></item>
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
        /// <para>The new name of the custom list. If this parameter is not specified, the original name is retained.</para>
        /// <para><b>Naming rules</b>: Only letters, digits, and underscores are supported (<c>^\\w{1,64}$</c>). The name must be 1 to 64 characters in length.</para>
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
