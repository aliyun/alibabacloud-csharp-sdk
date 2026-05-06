// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ListTaskGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<ListTaskGroupResponseBodyResultObject> ResultObject { get; set; }
        public class ListTaskGroupResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1588820785212</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public long? CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("GroupStatus")]
            [Validation(Required=false)]
            public string GroupStatus { get; set; }

            [NameInMap("SampleNames")]
            [Validation(Required=false)]
            public List<string> SampleNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("SubTaskCount")]
            [Validation(Required=false)]
            public int? SubTaskCount { get; set; }

            [NameInMap("SubTaskList")]
            [Validation(Required=false)]
            public List<ListTaskGroupResponseBodyResultObjectSubTaskList> SubTaskList { get; set; }
            public class ListTaskGroupResponseBodyResultObjectSubTaskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-12 15:47:23</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pts-demo</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HideViewResultButton")]
                [Validation(Required=false)]
                public bool? HideViewResultButton { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCharge")]
                [Validation(Required=false)]
                public bool? IsCharge { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rfs</para>
                /// </summary>
                [NameInMap("ModelScene")]
                [Validation(Required=false)]
                public string ModelScene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SampleId")]
                [Validation(Required=false)]
                public int? SampleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fs</para>
                /// </summary>
                [NameInMap("SampleName")]
                [Validation(Required=false)]
                public string SampleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>anti_fraud_riskscreening</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SubTaskId")]
                [Validation(Required=false)]
                public int? SubTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportCancel")]
                [Validation(Required=false)]
                public bool? SupportCancel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportDownload")]
                [Validation(Required=false)]
                public bool? SupportDownload { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SupportMergeSelect")]
                [Validation(Required=false)]
                public bool? SupportMergeSelect { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportView")]
                [Validation(Required=false)]
                public bool? SupportView { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FINANCE</para>
                /// </summary>
                [NameInMap("Tab")]
                [Validation(Required=false)]
                public string Tab { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TaskGroupId")]
                [Validation(Required=false)]
                public int? TaskGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>g-uf62fwvw2f8dx88xo2lt</para>
            /// </summary>
            [NameInMap("TaskGroupId")]
            [Validation(Required=false)]
            public int? TaskGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GroupTest</para>
            /// </summary>
            [NameInMap("TaskGroupName")]
            [Validation(Required=false)]
            public string TaskGroupName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
