// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class GetPictureSearchResultsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPictureSearchResultsResponseBodyData> Data { get; set; }
        public class GetPictureSearchResultsResponseBodyData : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("LeftUpperCornerXCoordinate")]
            [Validation(Required=false)]
            public string LeftUpperCornerXCoordinate { get; set; }

            [NameInMap("LeftUpperCornerYCoordinate")]
            [Validation(Required=false)]
            public string LeftUpperCornerYCoordinate { get; set; }

            [NameInMap("LocationMarkTime")]
            [Validation(Required=false)]
            public string LocationMarkTime { get; set; }

            [NameInMap("PictureId1")]
            [Validation(Required=false)]
            public string PictureId1 { get; set; }

            [NameInMap("PictureId2")]
            [Validation(Required=false)]
            public string PictureId2 { get; set; }

            [NameInMap("PictureUrl1")]
            [Validation(Required=false)]
            public string PictureUrl1 { get; set; }

            [NameInMap("PictureUrl2")]
            [Validation(Required=false)]
            public string PictureUrl2 { get; set; }

            [NameInMap("RightLowerCornerXCoordinate")]
            [Validation(Required=false)]
            public string RightLowerCornerXCoordinate { get; set; }

            [NameInMap("RightLowerCornerYCoordinate")]
            [Validation(Required=false)]
            public string RightLowerCornerYCoordinate { get; set; }

            [NameInMap("Similarity")]
            [Validation(Required=false)]
            public float? Similarity { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
