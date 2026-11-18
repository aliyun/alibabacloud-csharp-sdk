// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInspectionTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the assistant instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The summary of risk levels for inspection results. You can specify multiple values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: Normal.</description></item>
        /// <item><description>Warning: Warning.</description></item>
        /// <item><description>Error: High-risk.</description></item>
        /// <item><description>Failed: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Error</para>
        /// </summary>
        [NameInMap("LevelSummary")]
        [Validation(Required=false)]
        public string LevelSummary { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Manual task.</description></item>
        /// <item><description>2: Scheduled task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
