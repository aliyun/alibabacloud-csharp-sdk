// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateListRequest : TeaModel {
        /// <summary>
        /// <para>The description of the custom list. This parameter provides detailed information about the custom list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list items. This parameter provides the specific item data for the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// <para>The kind of the custom list. This parameter specifies the type of the custom list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The name of the custom list.</para>
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
