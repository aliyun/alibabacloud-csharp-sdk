// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeEcdReportTasksRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20。</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INIT: initializing</description></item>
        /// <item><description>FAILED</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>EXPIRED</description></item>
        /// <item><description>FINISHED</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The sub-type of the report export task.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>DESKTOP: cloud computer</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The ID of the report export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ret-sfkdsjfi*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the report.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>RESOURCE_REPORT</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE_REPORT</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
