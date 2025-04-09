// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobGroupExportTaskProgressRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>b3dbfb82-1ae6-4e73-b717-f494727d2af3</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e4e2a770-b97b-465a-80d8-06dca008c503</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
