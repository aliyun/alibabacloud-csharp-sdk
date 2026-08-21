// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAbnormalEventsCountRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ijff4be-bf24-4070-89ca-c47c879b0g32</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725801327754</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public float? End { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz9d00ut2ska3mlyhn6j</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>The severity level of abnormal events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>potential</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The namespace of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The pod name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pod</para>
        /// </summary>
        [NameInMap("pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// <para>Specifies whether to display abnormal events of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("showPod")]
        [Validation(Required=false)]
        public int? ShowPod { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725797727754</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public float? Start { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
