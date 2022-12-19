// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotPresetResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotPresetResponseBodyData Data { get; set; }
        public class GetHoneypotPresetResponseBodyData : TeaModel {
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }

            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetHoneypotPresetResponseBodyDataFileInfoList> FileInfoList { get; set; }
            public class GetHoneypotPresetResponseBodyDataFileInfoList : TeaModel {
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("OssUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

            }

            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            [NameInMap("HoneypotPresetId")]
            [Validation(Required=false)]
            public string HoneypotPresetId { get; set; }

            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("PresetName")]
            [Validation(Required=false)]
            public string PresetName { get; set; }

            [NameInMap("PresetType")]
            [Validation(Required=false)]
            public string PresetType { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
