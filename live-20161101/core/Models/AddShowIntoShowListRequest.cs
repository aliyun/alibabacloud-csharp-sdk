// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddShowIntoShowListRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("LiveInputType")]
        [Validation(Required=false)]
        public int? LiveInputType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ResourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

        [NameInMap("ShowName")]
        [Validation(Required=false)]
        public string ShowName { get; set; }

        [NameInMap("Spot")]
        [Validation(Required=false)]
        public int? Spot { get; set; }

        [NameInMap("isBatchMode")]
        [Validation(Required=false)]
        public bool? IsBatchMode { get; set; }

        [NameInMap("showList")]
        [Validation(Required=false)]
        public List<AddShowIntoShowListRequestShowList> ShowList { get; set; }
        public class AddShowIntoShowListRequestShowList : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("liveInputType")]
            [Validation(Required=false)]
            public int? LiveInputType { get; set; }

            [NameInMap("repeatTimes")]
            [Validation(Required=false)]
            public int? RepeatTimes { get; set; }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

            [NameInMap("showName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

    }

}
