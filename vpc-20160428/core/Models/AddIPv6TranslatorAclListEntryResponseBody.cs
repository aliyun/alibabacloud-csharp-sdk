// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddIPv6TranslatorAclListEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transaclentry-bp105jrs****</para>
        /// </summary>
        [NameInMap("AclEntryId")]
        [Validation(Required=false)]
        public string AclEntryId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B2F5262-6B57-43F2-defr345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
