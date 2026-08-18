// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDomainItemsRequest : TeaModel {
        /// <summary>
        /// <para>The current page number in paging.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The domain name value filter. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ItemValue")]
        [Validation(Required=false)]
        public string ItemValue { get; set; }

        /// <summary>
        /// <para>The list ID. This is a unique business identifier used for policy references and CRUD operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladl-6f1exxxxx6ab59</para>
        /// </summary>
        [NameInMap("ListId")]
        [Validation(Required=false)]
        public string ListId { get; set; }

        /// <summary>
        /// <para>The list type (Blacklist/Whitelist).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_white_list</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

        /// <summary>
        /// <para>The number of entries per page in paging. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
