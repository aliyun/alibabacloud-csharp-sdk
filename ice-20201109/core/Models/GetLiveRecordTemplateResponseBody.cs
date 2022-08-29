// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordTemplateResponseBody : TeaModel {
        [NameInMap("RecordTemplate")]
        [Validation(Required=false)]
        public GetLiveRecordTemplateResponseBodyRecordTemplate RecordTemplate { get; set; }
        public class GetLiveRecordTemplateResponseBodyRecordTemplate : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RecordFormatList")]
            [Validation(Required=false)]
            public List<GetLiveRecordTemplateResponseBodyRecordTemplateRecordFormatList> RecordFormatList { get; set; }
            public class GetLiveRecordTemplateResponseBodyRecordTemplateRecordFormatList : TeaModel {
                public int? CycleDuration { get; set; }
                public string Format { get; set; }
                public string OssObjectPrefix { get; set; }
                public int? SliceDuration { get; set; }
                public string SliceOssObjectPrefix { get; set; }
            }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
