// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeInspectionTaskAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation date of the inspection task. The format is YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-01</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The cron expression for the scheduled inspection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 2 * * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The IDs of the PolarDB clusters to be inspected. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-001,pc-002</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The expiration date of the inspection task. The format is YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-31</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The last modification date of the inspection task. The format is YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-01</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The description of the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled inspection task</para>
        /// </summary>
        [NameInMap("TaskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>The ID of the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
