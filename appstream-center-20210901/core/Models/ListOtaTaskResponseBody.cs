// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListOtaTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<ListOtaTaskResponseBodyTaskList> TaskList { get; set; }
        public class ListOtaTaskResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.1-R-20220708.110604</para>
            /// </summary>
            [NameInMap("OtaVersion")]
            [Validation(Required=false)]
            public string OtaVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("TaskDisplayStatus")]
            [Validation(Required=false)]
            public string TaskDisplayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ota-be7jzm29wrrz5****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-04T14:36:00+08:00</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
