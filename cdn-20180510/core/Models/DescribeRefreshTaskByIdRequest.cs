// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshTaskByIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/91164.html">RefreshObjectCaches</a> operation to query task IDs. Then, you can use the task IDs to query task status.</para>
        /// <para>You can specify up to 10 task IDs. Separate task IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
