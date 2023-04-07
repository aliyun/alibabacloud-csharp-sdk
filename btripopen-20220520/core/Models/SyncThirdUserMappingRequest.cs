// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class SyncThirdUserMappingRequest : TeaModel {
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("third_channel_type")]
        [Validation(Required=false)]
        public string ThirdChannelType { get; set; }

        [NameInMap("third_user_id")]
        [Validation(Required=false)]
        public string ThirdUserId { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
