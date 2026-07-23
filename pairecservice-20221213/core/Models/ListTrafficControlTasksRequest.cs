// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return all results without pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The filter for traffic control targets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>All</c>: Returns all traffic control targets.</para>
        /// </description></item>
        /// <item><description><para><c>Valid</c>: Returns only active traffic control targets. A traffic control target is active if the current time is within the specified start and end time.</para>
        /// </description></item>
        /// <item><description><para><c>None</c>: Does not return any traffic control targets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ControlTargetFilter")]
        [Validation(Required=false)]
        public string ControlTargetFilter { get; set; }

        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Daily</c>: the daily environment</para>
        /// </description></item>
        /// <item><description><para><c>Pre</c>: the pre-production environment</para>
        /// </description></item>
        /// <item><description><para><c>Prod</c>: the production environment</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID. You can obtain this ID by calling the <a href="https://icms.alibaba-inc.com/content/learn/pai?l=1%5C&m=16768%5C&n=4300782">ListInstances</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the traffic control task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ASC</c>: ascending order</para>
        /// </description></item>
        /// <item><description><para><c>DESC</c>: descending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the scene. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>GmtCreateTime</c>: Sorts the results by creation time.</para>
        /// </description></item>
        /// <item><description><para><c>GmtModifiedTime</c>: Sorts the results by modification time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NotRunning</c>: The task is not running.</para>
        /// </description></item>
        /// <item><description><para><c>Ready</c>: The task is ready to run.</para>
        /// </description></item>
        /// <item><description><para><c>Running</c>: The task is running.</para>
        /// </description></item>
        /// <item><description><para><c>Finished</c>: The task is finished.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the traffic control task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        /// <summary>
        /// <para>The version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Latest</c>: The latest version. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>Released</c>: the released version</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Latest</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
