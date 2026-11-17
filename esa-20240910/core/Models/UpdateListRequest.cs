// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateListRequest : TeaModel {
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
        /// <para><b>Full overwrite semantics</b>: The specified Items completely overwrite the existing list items instead of being appended to them.</para>
        /// <remarks>
        /// <para>⚠️ <b>If you do not specify this parameter or specify an empty value, the existing list items are cleared</b>. To retain the existing items and append new ones, call the GetList operation to retrieve the existing Items, concatenate the new items, and then submit them all at once.</para>
        /// </remarks>
        /// <para><b>Item format</b>: The format depends on the Kind specified when the list was created. The UpdateList operation does not support modifying the Kind.</para>
        /// <list type="bullet">
        /// <item><description>If Kind is set to ip: Each item must be a valid IP address or CIDR block. If an item is invalid, the WrongValueMatched error is returned.</description></item>
        /// <item><description>For other Kind values: The item format follows the specified conventions. The number of items is limited by the tenant quota NumberItemsPerList. This limit does not apply to the ip kind.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// <para>The updated name of the custom list. This parameter is required if you want to update the name. If you do not specify this parameter, the original name is retained.</para>
        /// <para><b>Naming rules</b>: The name can contain only letters, digits, and underscores (<c>^\\w{1,64}$</c>) and must be 1 to 64 characters in length.</para>
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
