// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteUsageDetailDataExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task. You can call the <a href="https://help.aliyun.com/document_detail/91062.html">DescribeUserUsageDataExportTask</a> operation to query tasks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
