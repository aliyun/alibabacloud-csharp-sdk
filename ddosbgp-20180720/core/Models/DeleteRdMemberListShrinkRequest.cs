// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DeleteRdMemberListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of the members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public string MemberListShrink { get; set; }

    }

}
