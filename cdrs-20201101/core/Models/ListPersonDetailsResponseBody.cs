// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListPersonDetailsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPersonDetailsResponseBodyData> Data { get; set; }
        public class ListPersonDetailsResponseBodyData : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("BodyTargetImage")]
            [Validation(Required=false)]
            public string BodyTargetImage { get; set; }

            [NameInMap("PreferredColor")]
            [Validation(Required=false)]
            public string PreferredColor { get; set; }

            [NameInMap("HotSpotAddress")]
            [Validation(Required=false)]
            public string HotSpotAddress { get; set; }

            [NameInMap("Age")]
            [Validation(Required=false)]
            public string Age { get; set; }

            [NameInMap("PersonType")]
            [Validation(Required=false)]
            public string PersonType { get; set; }

            [NameInMap("Transportation")]
            [Validation(Required=false)]
            public string Transportation { get; set; }

            [NameInMap("Profession")]
            [Validation(Required=false)]
            public string Profession { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("FaceSourceImage")]
            [Validation(Required=false)]
            public string FaceSourceImage { get; set; }

            [NameInMap("FaceTargetImage")]
            [Validation(Required=false)]
            public string FaceTargetImage { get; set; }

            [NameInMap("PrefOutTime")]
            [Validation(Required=false)]
            public string PrefOutTime { get; set; }

            [NameInMap("BodySourceImage")]
            [Validation(Required=false)]
            public string BodySourceImage { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
