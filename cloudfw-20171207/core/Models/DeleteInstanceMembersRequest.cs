// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteInstanceMembersRequest : TeaModel {
        /// <summary>
        /// The unique identifiers (UID) of members that you want to remove from Cloud Firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MemberUids")]
        [Validation(Required=false)]
        public List<long?> MemberUids { get; set; }

    }

}
