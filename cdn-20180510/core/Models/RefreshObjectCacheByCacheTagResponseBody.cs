// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class RefreshObjectCacheByCacheTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the refresh task. If multiple tasks are returned, the task IDs are separated by commas (,). The task IDs are merged based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the tasks are specified for the same accelerated domain name, submitted within the same second, and run to refresh content based on URLs instead of directories, the task IDs are merged into one task ID (RefreshTaskId).</description></item>
        /// <item><description>If the number of tasks that are specified for the same accelerated domain name, submitted within the same second, and run to refresh content based on URLs instead of directories exceeds 2,000, every 2,000 task IDs are merged into one task ID (RefreshTaskId).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>17772470184</para>
        /// </summary>
        [NameInMap("RefreshTaskId")]
        [Validation(Required=false)]
        public string RefreshTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E5AD83F-BD7B-462E-8319-2E30E305519A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
