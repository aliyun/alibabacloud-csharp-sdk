// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskListResponseBodyData Data { get; set; }
        public class QueryTaskListResponseBodyData : TeaModel {
            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public List<QueryTaskListResponseBodyDataTaskInfo> TaskInfo { get; set; }
            public class QueryTaskListResponseBodyDataTaskInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("Clientip")]
                [Validation(Required=false)]
                public string Clientip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Dec 26,2017 11:00:54</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("TaskCancelStatus")]
                [Validation(Required=false)]
                public string TaskCancelStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskCancelStatusCode")]
                [Validation(Required=false)]
                public int? TaskCancelStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8b1cd755-4928-4b02-adee-e5d41d7b1939</para>
                /// </summary>
                [NameInMap("TaskNo")]
                [Validation(Required=false)]
                public string TaskNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskNum")]
                [Validation(Required=false)]
                public int? TaskNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskStatusCode")]
                [Validation(Required=false)]
                public int? TaskStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CREATE_DNSHOST</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                [NameInMap("TaskTypeDescription")]
                [Validation(Required=false)]
                public string TaskTypeDescription { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8D7D294A-8E99-481F-B64C-017EFC793059</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
