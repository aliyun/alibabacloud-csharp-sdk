// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMcuJobResponseBody : TeaModel {
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryMcuJobResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryMcuJobResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public QueryMcuJobResponseBodyJobResult JobResult { get; set; }
        public class QueryMcuJobResponseBodyJobResult : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryMcuJobResponseBodyJobResultJob> Job { get; set; }
            public class QueryMcuJobResponseBodyJobResultJob : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<QueryMcuJobResponseBodyJobResultJobTag> Tag { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobTag : TeaModel {
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("ImageUrl")]
                    [Validation(Required=false)]
                    public string ImageUrl { get; set; }

                    [NameInMap("FrameTagInfos")]
                    [Validation(Required=false)]
                    public QueryMcuJobResponseBodyJobResultJobTagFrameTagInfos FrameTagInfos { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobTagFrameTagInfos : TeaModel {
                        [NameInMap("FrameTagInfo")]
                        [Validation(Required=false)]
                        public List<QueryMcuJobResponseBodyJobResultJobTagFrameTagInfosFrameTagInfo> FrameTagInfo { get; set; }
                        public class QueryMcuJobResponseBodyJobResultJobTagFrameTagInfosFrameTagInfo : TeaModel {
                            public string Score { get; set; }
                            public string Category { get; set; }
                            public string Tag { get; set; }
                        }
                    };

                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                }

            }
        };

    }

}
