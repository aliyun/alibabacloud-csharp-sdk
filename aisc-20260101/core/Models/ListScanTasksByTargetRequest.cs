// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListScanTasksByTargetRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from 1. If the value is less than 1, it is normalized to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100. If the value is greater than 100, it is clamped to 100. If the value is less than 1, a 400 error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Filters tasks by detection intensity. If this parameter is not specified, tasks are not filtered by intensity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SampleLevel")]
        [Validation(Required=false)]
        public string SampleLevel { get; set; }

        /// <summary>
        /// <para>Filters tasks by scan mode. If this parameter is not specified, tasks of all modes are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attack</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the scan target. Only tasks under this target are queried. If the target does not exist or does not belong to the current tenant, a 400 error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-abc123def4567</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>Filters tasks by task status. If this parameter is not specified, tasks of all statuses are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
