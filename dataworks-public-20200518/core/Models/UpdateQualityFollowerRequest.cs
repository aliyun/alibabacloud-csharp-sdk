// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateQualityFollowerRequest : TeaModel {
        [NameInMap("AlarmMode")]
        [Validation(Required=false)]
        public int? AlarmMode { get; set; }

        [NameInMap("Follower")]
        [Validation(Required=false)]
        public string Follower { get; set; }

        [NameInMap("FollowerId")]
        [Validation(Required=false)]
        public long? FollowerId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
