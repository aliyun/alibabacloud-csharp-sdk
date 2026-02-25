// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpFileDeleteJobListResponseBody : TeaModel {
        [NameInMap("FpFileDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobList FpFileDeleteJobList { get; set; }
        public class QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobList : TeaModel {
            [NameInMap("FpFileDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobListFpFileDeleteJob> FpFileDeleteJob { get; set; }
            public class QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobListFpFileDeleteJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("FileIds")]
                [Validation(Required=false)]
                public string FileIds { get; set; }

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
        public QueryFpFileDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpFileDeleteJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D127C68E-F1A1-4CE5-A874-8FF724881A12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
