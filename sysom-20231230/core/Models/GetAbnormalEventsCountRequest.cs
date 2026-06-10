// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAbnormalEventsCountRequest : TeaModel {
        /// <summary>
        /// <para>cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ijff4be-bf24-4070-89ca-c47c879b0g32</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

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
        /// <para>instance ID.</para>
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
        /// <para>Name of the pod</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pod</para>
        /// </summary>
        [NameInMap("pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// <para>is whether to display pod anomalous activity</para>
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
