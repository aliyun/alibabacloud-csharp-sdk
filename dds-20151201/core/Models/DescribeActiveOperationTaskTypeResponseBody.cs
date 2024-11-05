// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7EE83BF-7BA8-5087-BAC9-ED85ED54****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The O\&amp;M tasks.</para>
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskTypeResponseBodyTypeList> TypeList { get; set; }
        public class DescribeActiveOperationTaskTypeResponseBodyTypeList : TeaModel {
            /// <summary>
            /// <para>The number of pending tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>rds_apsaradb_transfer</b>: data migration</description></item>
            /// <item><description><b>rds_apsaradb_upgrade</b>: minor version update</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The task type in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskTypeInfoEn")]
            [Validation(Required=false)]
            public string TaskTypeInfoEn { get; set; }

            /// <summary>
            /// <para>The task type in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_apsaradb_upgrade</para>
            /// </summary>
            [NameInMap("TaskTypeInfoZh")]
            [Validation(Required=false)]
            public string TaskTypeInfoZh { get; set; }

        }

    }

}
