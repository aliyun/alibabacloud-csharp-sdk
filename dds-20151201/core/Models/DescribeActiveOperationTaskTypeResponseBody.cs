// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskTypeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The O\&M tasks.
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
            /// *   \*\*rds_apsaradb_transfer\*\*: data migration
            /// *   \*\*rds_apsaradb_upgrade\*\*: minor version update
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The task type in English.
            /// </summary>
            [NameInMap("TaskTypeInfoEn")]
            [Validation(Required=false)]
            public string TaskTypeInfoEn { get; set; }

            /// <summary>
            /// The task type in Chinese.
            /// </summary>
            [NameInMap("TaskTypeInfoZh")]
            [Validation(Required=false)]
            public string TaskTypeInfoZh { get; set; }

        }

    }

}
