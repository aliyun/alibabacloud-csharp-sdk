// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListImportTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListImportTasksResponseBodyItems> Items { get; set; }
        public class ListImportTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Creation time in UTC, formatted as YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>Milvus version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// <para>Job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Importing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Target instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp*****</para>
            /// </summary>
            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>342900000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>Job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>362c6c7a-4d20-4eac-898c-1495ceab374c</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>Job type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>import</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>Number of records per page. Valid values: <b>1–100</b>.</para>
        /// <para>Default value: <b>30</b>.  </para>
        /// <remarks>
        /// <para>If this parameter is specified, the <b>PageSize</b> and <b>PageNumber</b> parameters are unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Paging cursor identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E43AAE0-BEE8-43DA-860D-EAF2AA0724DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
