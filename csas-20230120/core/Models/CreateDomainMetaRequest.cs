// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateDomainMetaRequest : TeaModel {
        /// <summary>
        /// <para>The list type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_black_list</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

        /// <summary>
        /// <para>The name of the list. The name can be up to 32 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>office_domain</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
