// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppRecordTemplatesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeAppRecordTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeAppRecordTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public byte[] CreateTime { get; set; }

            [NameInMap("DelayStopTime")]
            [Validation(Required=false)]
            public long? DelayStopTime { get; set; }

            [NameInMap("FilePrefix")]
            [Validation(Required=false)]
            public string FilePrefix { get; set; }

            [NameInMap("FileSplitInterval")]
            [Validation(Required=false)]
            public long? FileSplitInterval { get; set; }

            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<string> Formats { get; set; }

            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<long?> LayoutIds { get; set; }

            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
