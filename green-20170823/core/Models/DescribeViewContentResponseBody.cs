// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeViewContentResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ViewContentList")]
        [Validation(Required=false)]
        public List<DescribeViewContentResponseBodyViewContentList> ViewContentList { get; set; }
        public class DescribeViewContentResponseBodyViewContentList : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("FaceResults")]
            [Validation(Required=false)]
            public List<DescribeViewContentResponseBodyViewContentListFaceResults> FaceResults { get; set; }
            public class DescribeViewContentResponseBodyViewContentListFaceResults : TeaModel {
                [NameInMap("Age")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsAge Age { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsAge : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public int? Value { get; set; }

                }

                [NameInMap("Bang")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsBang Bang { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsBang : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Bualified")]
                [Validation(Required=false)]
                public bool? Bualified { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsGender Gender { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsGender : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Glasses")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsGlasses Glasses { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsGlasses : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Hairstyle")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsHairstyle Hairstyle { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsHairstyle : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Hat")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsHat Hat { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsHat : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsImage Image { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsImage : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsLocation Location { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsLocation : TeaModel {
                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public int? H { get; set; }

                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public int? W { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

                [NameInMap("Mustache")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsMustache Mustache { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsMustache : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Quality")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsQuality Quality { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsQuality : TeaModel {
                    [NameInMap("Blur")]
                    [Validation(Required=false)]
                    public float? Blur { get; set; }

                    [NameInMap("Pitch")]
                    [Validation(Required=false)]
                    public float? Pitch { get; set; }

                    [NameInMap("Roll")]
                    [Validation(Required=false)]
                    public float? Roll { get; set; }

                    [NameInMap("Yaw")]
                    [Validation(Required=false)]
                    public float? Yaw { get; set; }

                }

                [NameInMap("Respirator")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsRespirator Respirator { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsRespirator : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Smile")]
                [Validation(Required=false)]
                public DescribeViewContentResponseBodyViewContentListFaceResultsSmile Smile { get; set; }
                public class DescribeViewContentResponseBodyViewContentListFaceResultsSmile : TeaModel {
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

            }

            [NameInMap("FrameResults")]
            [Validation(Required=false)]
            public List<DescribeViewContentResponseBodyViewContentListFrameResults> FrameResults { get; set; }
            public class DescribeViewContentResponseBodyViewContentListFrameResults : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("NewUrl")]
            [Validation(Required=false)]
            public string NewUrl { get; set; }

            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<DescribeViewContentResponseBodyViewContentListResults> Results { get; set; }
            public class DescribeViewContentResponseBodyViewContentListResults : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            [NameInMap("ScanFinishedTime")]
            [Validation(Required=false)]
            public string ScanFinishedTime { get; set; }

            [NameInMap("ScanResult")]
            [Validation(Required=false)]
            public string ScanResult { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
