// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAbnormalyEventsRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d33d4be-bf54-4070-82ca-c1dc2d8b1562</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>This field is present when paging is used and indicates the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>End time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725801327754</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public float? End { get; set; }

        /// <summary>
        /// <para>Anomalous activity name</para>
        /// 
        /// <b>Example:</b>
        /// <para>节点根文件系统使用检测</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz9d00ut2ska3mlyhn6j</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>Level of the anomalous activity</para>
        /// 
        /// <b>Example:</b>
        /// <para>potential</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>Namespace where the pod is located</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Page size. The default value is 5. Valid values are in the range [1,100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Pod name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pod</para>
        /// </summary>
        [NameInMap("pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// <para>Whether to display anomalous activities of the pod</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("showPod")]
        [Validation(Required=false)]
        public int? ShowPod { get; set; }

        /// <summary>
        /// <para>Start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725797727754</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public float? Start { get; set; }

    }

}
