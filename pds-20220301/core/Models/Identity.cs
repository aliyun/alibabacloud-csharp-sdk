// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Identity : TeaModel {
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IT_User</para>
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
