// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteDomainMetaRequest : TeaModel {
        /// <summary>
        /// <para>The list ID, which is a unique business identifier used for policy references and create, update, and delete operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladl-6f1exxxxx6ab59</para>
        /// </summary>
        [NameInMap("ListId")]
        [Validation(Required=false)]
        public string ListId { get; set; }

        /// <summary>
        /// <para>The list type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>la_domain_white_list: domain name whitelist.</description></item>
        /// <item><description>la_domain_black_list: domain name blacklist.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_white_list</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

    }

}
