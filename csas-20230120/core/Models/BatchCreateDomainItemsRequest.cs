// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class BatchCreateDomainItemsRequest : TeaModel {
        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("DomainItems")]
        [Validation(Required=false)]
        public List<string> DomainItems { get; set; }

        /// <summary>
        /// <para>The ID of the list. This is a unique business identifier used for policy reference and addition, deletion, and modification operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladl-61aae0c0ba715e3b</para>
        /// </summary>
        [NameInMap("ListId")]
        [Validation(Required=false)]
        public string ListId { get; set; }

        /// <summary>
        /// <para>The type of the list (Blacklist/Whitelist).</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_white_list</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

    }

}
