// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteInstanceMembersRequest : TeaModel {
        /// <summary>
        /// <para>The UIDs of the members.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234123412341234</para>
        /// </summary>
        [NameInMap("MemberUids")]
        [Validation(Required=false)]
        public List<long?> MemberUids { get; set; }

    }

}
