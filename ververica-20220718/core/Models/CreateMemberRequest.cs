// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateMemberRequest : TeaModel {
        /// <summary>
        /// The mappings between the ID and permissions of the member.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Member Body { get; set; }

    }

}
