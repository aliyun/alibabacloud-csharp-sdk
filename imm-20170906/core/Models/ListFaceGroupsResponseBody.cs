// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListFaceGroupsResponseBody : TeaModel {
        [NameInMap("FaceGroups")]
        [Validation(Required=false)]
        public List<ListFaceGroupsResponseBodyFaceGroups> FaceGroups { get; set; }
        public class ListFaceGroupsResponseBodyFaceGroups : TeaModel {
            [NameInMap("AverageAge")]
            [Validation(Required=false)]
            public float? AverageAge { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("FaceCount")]
            [Validation(Required=false)]
            public int? FaceCount { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("GroupCoverFace")]
            [Validation(Required=false)]
            public ListFaceGroupsResponseBodyFaceGroupsGroupCoverFace GroupCoverFace { get; set; }
            public class ListFaceGroupsResponseBodyFaceGroupsGroupCoverFace : TeaModel {
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }
                [NameInMap("FaceBoundary")]
                [Validation(Required=false)]
                public ListFaceGroupsResponseBodyFaceGroupsGroupCoverFaceFaceBoundary FaceBoundary { get; set; }
                public class ListFaceGroupsResponseBodyFaceGroupsGroupCoverFaceFaceBoundary : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }

                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }
                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }
                [NameInMap("ImageHeight")]
                [Validation(Required=false)]
                public long? ImageHeight { get; set; }
                [NameInMap("ImageUri")]
                [Validation(Required=false)]
                public string ImageUri { get; set; }
                [NameInMap("ImageWidth")]
                [Validation(Required=false)]
                public long? ImageWidth { get; set; }
            };

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            [NameInMap("MaxAge")]
            [Validation(Required=false)]
            public float? MaxAge { get; set; }

            [NameInMap("MinAge")]
            [Validation(Required=false)]
            public float? MinAge { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("RemarksA")]
            [Validation(Required=false)]
            public string RemarksA { get; set; }

            [NameInMap("RemarksArrayA")]
            [Validation(Required=false)]
            public string RemarksArrayA { get; set; }

            [NameInMap("RemarksArrayB")]
            [Validation(Required=false)]
            public string RemarksArrayB { get; set; }

            [NameInMap("RemarksB")]
            [Validation(Required=false)]
            public string RemarksB { get; set; }

            [NameInMap("RemarksC")]
            [Validation(Required=false)]
            public string RemarksC { get; set; }

            [NameInMap("RemarksD")]
            [Validation(Required=false)]
            public string RemarksD { get; set; }

        }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
