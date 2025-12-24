// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class QueryPredictiveTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfos")]
        [Validation(Required=false)]
        public QueryPredictiveTaskInfoResponseBodyTaskInfos TaskInfos { get; set; }
        public class QueryPredictiveTaskInfoResponseBodyTaskInfos : TeaModel {
            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public List<QueryPredictiveTaskInfoResponseBodyTaskInfosTaskInfo> TaskInfo { get; set; }
            public class QueryPredictiveTaskInfoResponseBodyTaskInfosTaskInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public int? MaxValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public int? MinValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-17T10:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

    }

}
