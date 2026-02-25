// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpDBDeleteJobListResponseBody : TeaModel {
        [NameInMap("FpDBDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList FpDBDeleteJobList { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList : TeaModel {
            [NameInMap("FpDBDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob> FpDBDeleteJob { get; set; }
            public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DelType")]
                [Validation(Required=false)]
                public string DelType { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4247B23C-26DE-529F-8D9F-FD6811AE979B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
