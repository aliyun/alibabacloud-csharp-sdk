// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        /// <summary>
        /// 静默时间，扩容出的节点，在静默时间过后，方可进入缩容判断
        /// </summary>
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        /// <summary>
        /// GPU缩容阈值，节点上 Request 的资源与总资源量的比值
        /// </summary>
        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        /// <summary>
        /// 弹性灵敏度，判断伸缩的间隔时间
        /// </summary>
        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// 缩容触发时延，节点缩容时需要连续满足触发时延所设定的时间，方可进行缩容
        /// </summary>
        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        /// <summary>
        /// 缩容阈值，节点上 Request 的资源与总资源量的比值
        /// </summary>
        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
