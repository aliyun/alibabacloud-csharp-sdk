// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class RemoveMemberRequest : TeaModel {
        /// <summary>
        /// 会议唯一标识
        /// </summary>
        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 被邀请用户ID
        /// </summary>
        [NameInMap("ToUserId")]
        [Validation(Required=false)]
        public string ToUserId { get; set; }

        /// <summary>
        /// 邀请者用户ID
        /// </summary>
        [NameInMap("FromUserId")]
        [Validation(Required=false)]
        public string FromUserId { get; set; }

    }

}
