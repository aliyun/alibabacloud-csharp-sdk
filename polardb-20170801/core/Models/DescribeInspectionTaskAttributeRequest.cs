// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeInspectionTaskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the inspection task to query. This parameter is required. If this parameter is not specified, the service returns the InvalidTaskId.Malformed error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
