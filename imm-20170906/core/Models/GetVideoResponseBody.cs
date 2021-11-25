// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetVideoResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public int? FileSize { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("ProcessFailReason")]
        [Validation(Required=false)]
        public string ProcessFailReason { get; set; }

        [NameInMap("ProcessModifyTime")]
        [Validation(Required=false)]
        public string ProcessModifyTime { get; set; }

        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public string ProcessStatus { get; set; }

        [NameInMap("RemarksA")]
        [Validation(Required=false)]
        public string RemarksA { get; set; }

        [NameInMap("RemarksB")]
        [Validation(Required=false)]
        public string RemarksB { get; set; }

        [NameInMap("RemarksC")]
        [Validation(Required=false)]
        public string RemarksC { get; set; }

        [NameInMap("RemarksD")]
        [Validation(Required=false)]
        public string RemarksD { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("SourcePosition")]
        [Validation(Required=false)]
        public string SourcePosition { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("SourceUri")]
        [Validation(Required=false)]
        public string SourceUri { get; set; }

        [NameInMap("VideoDuration")]
        [Validation(Required=false)]
        public float? VideoDuration { get; set; }

        [NameInMap("VideoFacesFailReason")]
        [Validation(Required=false)]
        public string VideoFacesFailReason { get; set; }

        [NameInMap("VideoFacesModifyTime")]
        [Validation(Required=false)]
        public string VideoFacesModifyTime { get; set; }

        [NameInMap("VideoFacesStatus")]
        [Validation(Required=false)]
        public string VideoFacesStatus { get; set; }

        [NameInMap("VideoFormat")]
        [Validation(Required=false)]
        public string VideoFormat { get; set; }

        [NameInMap("VideoFrameTagsFailReason")]
        [Validation(Required=false)]
        public string VideoFrameTagsFailReason { get; set; }

        [NameInMap("VideoFrameTagsModifyTime")]
        [Validation(Required=false)]
        public string VideoFrameTagsModifyTime { get; set; }

        [NameInMap("VideoFrameTagsStatus")]
        [Validation(Required=false)]
        public string VideoFrameTagsStatus { get; set; }

        [NameInMap("VideoFrames")]
        [Validation(Required=false)]
        public int? VideoFrames { get; set; }

        [NameInMap("VideoHeight")]
        [Validation(Required=false)]
        public int? VideoHeight { get; set; }

        [NameInMap("VideoInfo")]
        [Validation(Required=false)]
        public string VideoInfo { get; set; }

        [NameInMap("VideoOCRFailReason")]
        [Validation(Required=false)]
        public string VideoOCRFailReason { get; set; }

        [NameInMap("VideoOCRModifyTime")]
        [Validation(Required=false)]
        public string VideoOCRModifyTime { get; set; }

        [NameInMap("VideoOCRStatus")]
        [Validation(Required=false)]
        public string VideoOCRStatus { get; set; }

        [NameInMap("VideoSTTFailReason")]
        [Validation(Required=false)]
        public string VideoSTTFailReason { get; set; }

        [NameInMap("VideoSTTModifyTime")]
        [Validation(Required=false)]
        public string VideoSTTModifyTime { get; set; }

        [NameInMap("VideoSTTStatus")]
        [Validation(Required=false)]
        public string VideoSTTStatus { get; set; }

        [NameInMap("VideoTags")]
        [Validation(Required=false)]
        public List<GetVideoResponseBodyVideoTags> VideoTags { get; set; }
        public class GetVideoResponseBodyVideoTags : TeaModel {
            [NameInMap("ParentTagName")]
            [Validation(Required=false)]
            public string ParentTagName { get; set; }

            [NameInMap("TagConfidence")]
            [Validation(Required=false)]
            public float? TagConfidence { get; set; }

            [NameInMap("TagLevel")]
            [Validation(Required=false)]
            public int? TagLevel { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        [NameInMap("VideoTagsFailReason")]
        [Validation(Required=false)]
        public string VideoTagsFailReason { get; set; }

        [NameInMap("VideoTagsModifyTime")]
        [Validation(Required=false)]
        public string VideoTagsModifyTime { get; set; }

        [NameInMap("VideoTagsStatus")]
        [Validation(Required=false)]
        public string VideoTagsStatus { get; set; }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

        [NameInMap("VideoWidth")]
        [Validation(Required=false)]
        public int? VideoWidth { get; set; }

    }

}
