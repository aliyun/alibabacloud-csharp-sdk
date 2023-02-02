// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskTypeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of tasks.
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskTypeResponseBodyTypeList> TypeList { get; set; }
        public class DescribeActiveOperationTaskTypeResponseBodyTypeList : TeaModel {
            /// <summary>
            /// The number of pending tasks.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **rds\_apsaradb\_transfer**: instance migration
            /// *   **rds\_apsaradb\_upgrade**: minor version update
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The task type (English).
            /// </summary>
            [NameInMap("TaskTypeInfoEn")]
            [Validation(Required=false)]
            public string TaskTypeInfoEn { get; set; }

            /// <summary>
            /// The task type (Chinese).
            /// </summary>
            [NameInMap("TaskTypeInfoZh")]
            [Validation(Required=false)]
            public string TaskTypeInfoZh { get; set; }

        }

    }

}
