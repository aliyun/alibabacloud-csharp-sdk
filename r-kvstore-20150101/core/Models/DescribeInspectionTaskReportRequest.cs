// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInspectionTaskReportRequest : TeaModel {
        /// <summary>
        /// <para>The inspection instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp19f4f6994813xxx</para>
        /// </summary>
        [NameInMap("InspectionInsId")]
        [Validation(Required=false)]
        public string InspectionInsId { get; set; }

        /// <summary>
        /// <para>The assistant instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta-bp19f4f6994813xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The summary of risk levels for inspection results. You can specify multiple values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: normal</description></item>
        /// <item><description>Warning: warning</description></item>
        /// <item><description>Error: high-risk</description></item>
        /// <item><description>Failed: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Error,Warning</para>
        /// </summary>
        [NameInMap("LevelSummary")]
        [Validation(Required=false)]
        public string LevelSummary { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tit-dca42f85c73644e0ab5c80ef64121axxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
