// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AutoRenewInstance : TeaModel {
        /// <summary>
        /// 自动续费。
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// 自动续费时长。
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// 自动付费时长单位。
        /// </summary>
        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        /// <summary>
        /// emr实例自动续费时长。
        /// </summary>
        [NameInMap("EmrAutoRenewDuration")]
        [Validation(Required=false)]
        public int? EmrAutoRenewDuration { get; set; }

        /// <summary>
        /// emr实例自动续费时长单位。
        /// </summary>
        [NameInMap("EmrAutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string EmrAutoRenewDurationUnit { get; set; }

        /// <summary>
        /// 节点ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
