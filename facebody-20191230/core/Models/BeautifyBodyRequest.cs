// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BeautifyBodyRequest : TeaModel {
        [NameInMap("AgeRange")]
        [Validation(Required=false)]
        public BeautifyBodyRequestAgeRange AgeRange { get; set; }
        public class BeautifyBodyRequestAgeRange : TeaModel {
            [NameInMap("AgeMax")]
            [Validation(Required=false)]
            public long? AgeMax { get; set; }
            [NameInMap("AgeMinimum")]
            [Validation(Required=false)]
            public long? AgeMinimum { get; set; }
        };

        [NameInMap("BodyBoxes")]
        [Validation(Required=false)]
        public List<BeautifyBodyRequestBodyBoxes> BodyBoxes { get; set; }
        public class BeautifyBodyRequestBodyBoxes : TeaModel {
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

        }

        [NameInMap("Custom")]
        [Validation(Required=false)]
        public long? Custom { get; set; }

        [NameInMap("FaceList")]
        [Validation(Required=false)]
        public List<BeautifyBodyRequestFaceList> FaceList { get; set; }
        public class BeautifyBodyRequestFaceList : TeaModel {
            [NameInMap("Age")]
            [Validation(Required=false)]
            public long? Age { get; set; }

            [NameInMap("FaceBox")]
            [Validation(Required=false)]
            public BeautifyBodyRequestFaceListFaceBox FaceBox { get; set; }
            public class BeautifyBodyRequestFaceListFaceBox : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }
            };

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public long? Gender { get; set; }

        }

        [NameInMap("FemaleLiquifyDegree")]
        [Validation(Required=false)]
        public float? FemaleLiquifyDegree { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("IsPregnant")]
        [Validation(Required=false)]
        public bool? IsPregnant { get; set; }

        [NameInMap("LengthenDegree")]
        [Validation(Required=false)]
        public float? LengthenDegree { get; set; }

        [NameInMap("MaleLiquifyDegree")]
        [Validation(Required=false)]
        public float? MaleLiquifyDegree { get; set; }

        [NameInMap("OriginalHeight")]
        [Validation(Required=false)]
        public long? OriginalHeight { get; set; }

        [NameInMap("OriginalWidth")]
        [Validation(Required=false)]
        public long? OriginalWidth { get; set; }

        [NameInMap("PoseList")]
        [Validation(Required=false)]
        public List<BeautifyBodyRequestPoseList> PoseList { get; set; }
        public class BeautifyBodyRequestPoseList : TeaModel {
            [NameInMap("Pose")]
            [Validation(Required=false)]
            public List<BeautifyBodyRequestPoseListPose> Pose { get; set; }
            public class BeautifyBodyRequestPoseListPose : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public long? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public long? Y { get; set; }

            }

        }

    }

}
