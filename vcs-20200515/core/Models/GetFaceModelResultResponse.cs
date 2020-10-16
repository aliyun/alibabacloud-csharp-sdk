// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetFaceModelResultResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetFaceModelResultResponseData Data { get; set; }
        public class GetFaceModelResultResponseData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<GetFaceModelResultResponseDataRecords> Records { get; set; }
            public class GetFaceModelResultResponseDataRecords : TeaModel {
                public string MustacheStyle { get; set; }
                public string FaceStyle { get; set; }
                public int? CapStyle { get; set; }
                public int? SkinColor { get; set; }
                public float? RightBottomY { get; set; }
                public float? RightBottomX { get; set; }
                public int? HairStyle { get; set; }
                public int? GenderCode { get; set; }
                public int? RespiratorColor { get; set; }
                public int? EthicCode { get; set; }
                public int? AgeLowerLimit { get; set; }
                public float? LeftTopY { get; set; }
                public float? LeftTopX { get; set; }
                public int? HairColor { get; set; }
                public int? AgeUpLimit { get; set; }
                public int? GlassStyle { get; set; }
                public int? GlassColor { get; set; }
                public int? CapColor { get; set; }
                public string CapColorReliability { get; set; }
                public string RespiratorColorReliability { get; set; }
                public string EthicCodeReliability { get; set; }
                public string GenderCodeReliability { get; set; }
                public string GlassColorReliability { get; set; }
                public string SkinColorReliability { get; set; }
                public string MustacheStyleReliability { get; set; }
                public string CapStyleReliability { get; set; }
                public string FaceStyleReliability { get; set; }
                public string GlassStyleReliability { get; set; }
                public string AgeUpLimitReliability { get; set; }
                public string HairStyleReliability { get; set; }
                public string AgeLowerLimitReliability { get; set; }
                public string HairColorReliability { get; set; }
                public List<string> FeatureData { get; set; }
            }
        };

    }

}
