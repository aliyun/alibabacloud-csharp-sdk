// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class BatchDeleteDomainItemsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of domain name list entries.</para>
        /// </summary>
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public List<long?> ItemIds { get; set; }

        /// <summary>
        /// <para>The list ID. This is the unique business identifier used for policy references and add, delete, and modify operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladl-61aae0c0ba715e3b</para>
        /// </summary>
        [NameInMap("ListId")]
        [Validation(Required=false)]
        public string ListId { get; set; }

        /// <summary>
        /// <para>The list type (Blacklist/Whitelist).</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_white_list</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

    }

}
