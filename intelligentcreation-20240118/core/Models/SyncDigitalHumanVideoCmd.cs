// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240118.Models
{
    public class SyncDigitalHumanVideoCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("imageScale")]
        [Validation(Required=false)]
        public string ImageScale { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("videoDuration")]
        [Validation(Required=false)]
        public int? VideoDuration { get; set; }

        [NameInMap("videoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        [NameInMap("videoTitle")]
        [Validation(Required=false)]
        public string VideoTitle { get; set; }

        [NameInMap("videoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
