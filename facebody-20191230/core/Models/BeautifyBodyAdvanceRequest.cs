// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BeautifyBodyAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("OriginalWidth")]
        [Validation(Required=false)]
        public long? OriginalWidth { get; set; }

        [NameInMap("OriginalHeight")]
        [Validation(Required=false)]
        public long? OriginalHeight { get; set; }

        [NameInMap("Custom")]
        [Validation(Required=false)]
        public long? Custom { get; set; }

        [NameInMap("MaleLiquifyDegree")]
        [Validation(Required=false)]
        public float? MaleLiquifyDegree { get; set; }

        [NameInMap("FemaleLiquifyDegree")]
        [Validation(Required=false)]
        public float? FemaleLiquifyDegree { get; set; }

        [NameInMap("LengthenDegree")]
        [Validation(Required=false)]
        public float? LengthenDegree { get; set; }

        [NameInMap("AgeRange")]
        [Validation(Required=false)]
        public BeautifyBodyAdvanceRequestAgeRange AgeRange { get; set; }
        public class BeautifyBodyAdvanceRequestAgeRange : TeaModel {
            [NameInMap("AgeMinimum")]
            [Validation(Required=false)]
            public long? AgeMinimum { get; set; }
            [NameInMap("AgeMax")]
            [Validation(Required=false)]
            public long? AgeMax { get; set; }
        };

        [NameInMap("BodyBoxes")]
        [Validation(Required=false)]
        public List<BeautifyBodyAdvanceRequestBodyBoxes> BodyBoxes { get; set; }
        public class BeautifyBodyAdvanceRequestBodyBoxes : TeaModel {
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

        }

        [NameInMap("FaceList")]
        [Validation(Required=false)]
        public List<BeautifyBodyAdvanceRequestFaceList> FaceList { get; set; }
        public class BeautifyBodyAdvanceRequestFaceList : TeaModel {
            [NameInMap("FaceBox")]
            [Validation(Required=false)]
            public BeautifyBodyAdvanceRequestFaceListFaceBox FaceBox { get; set; }
            public class BeautifyBodyAdvanceRequestFaceListFaceBox : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }
            };

            [NameInMap("Age")]
            [Validation(Required=false)]
            public long? Age { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public long? Gender { get; set; }

        }

        [NameInMap("PoseList")]
        [Validation(Required=false)]
        public List<BeautifyBodyAdvanceRequestPoseList> PoseList { get; set; }
        public class BeautifyBodyAdvanceRequestPoseList : TeaModel {
            [NameInMap("Pose")]
            [Validation(Required=false)]
            public List<BeautifyBodyAdvanceRequestPoseListPose> Pose { get; set; }
            public class BeautifyBodyAdvanceRequestPoseListPose : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public long? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public long? Y { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

    }

}
