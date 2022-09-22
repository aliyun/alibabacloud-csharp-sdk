// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class DetailSceneResponseBody : TeaModel {
        [NameInMap("Captures")]
        [Validation(Required=false)]
        public List<DetailSceneResponseBodyCaptures> Captures { get; set; }
        public class DetailSceneResponseBodyCaptures : TeaModel {
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("FloorPlans")]
        [Validation(Required=false)]
        public List<DetailSceneResponseBodyFloorPlans> FloorPlans { get; set; }
        public class DetailSceneResponseBodyFloorPlans : TeaModel {
            [NameInMap("ColorMapUrl")]
            [Validation(Required=false)]
            public string ColorMapUrl { get; set; }

            [NameInMap("FloorLabel")]
            [Validation(Required=false)]
            public string FloorLabel { get; set; }

            [NameInMap("FloorName")]
            [Validation(Required=false)]
            public string FloorName { get; set; }

            [NameInMap("MiniMapUrl")]
            [Validation(Required=false)]
            public string MiniMapUrl { get; set; }

        }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PreviewToken")]
        [Validation(Required=false)]
        public string PreviewToken { get; set; }

        [NameInMap("Published")]
        [Validation(Required=false)]
        public bool? Published { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceNum")]
        [Validation(Required=false)]
        public long? SourceNum { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusName")]
        [Validation(Required=false)]
        public string StatusName { get; set; }

        [NameInMap("SubSceneNum")]
        [Validation(Required=false)]
        public long? SubSceneNum { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
