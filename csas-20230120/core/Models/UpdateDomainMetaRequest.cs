// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateDomainMetaRequest : TeaModel {
        /// <summary>
        /// <para>The list ID. This is a unique business identifier used for policy references and add, delete, or modify operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladl-6f1exxxxx6ab59</para>
        /// </summary>
        [NameInMap("ListId")]
        [Validation(Required=false)]
        public string ListId { get; set; }

        /// <summary>
        /// <para>The list type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_white_list</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

        /// <summary>
        /// <para>The list name. Maximum length: 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_office_domain</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
