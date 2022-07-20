// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeJobsResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<ListLiveTranscodeJobsResponseBodyJobList> JobList { get; set; }
        public class ListLiveTranscodeJobsResponseBodyJobList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OutputStream")]
            [Validation(Required=false)]
            public ListLiveTranscodeJobsResponseBodyJobListOutputStream OutputStream { get; set; }
            public class ListLiveTranscodeJobsResponseBodyJobListOutputStream : TeaModel {
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public List<ListLiveTranscodeJobsResponseBodyJobListOutputStreamStreamInfos> StreamInfos { get; set; }
                public class ListLiveTranscodeJobsResponseBodyJobListOutputStreamStreamInfos : TeaModel {
                    public string OutputUrl { get; set; }
                    public string Type { get; set; }
                }
            };

            [NameInMap("StartMode")]
            [Validation(Required=false)]
            public int? StartMode { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public ListLiveTranscodeJobsResponseBodyJobListStreamInput StreamInput { get; set; }
            public class ListLiveTranscodeJobsResponseBodyJobListStreamInput : TeaModel {
                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
