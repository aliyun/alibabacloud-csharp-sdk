// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RenewInstance : TeaModel {
        /// <summary>
        /// emr实例续费时长。
        /// </summary>
        [NameInMap("EmrRenewDuration")]
        [Validation(Required=false)]
        public int? EmrRenewDuration { get; set; }

        /// <summary>
        /// emr实例续费时长单位。
        /// </summary>
        [NameInMap("EmrRenewDurationUnit")]
        [Validation(Required=false)]
        public string EmrRenewDurationUnit { get; set; }

        /// <summary>
        /// 节点ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 续费时长。
        /// </summary>
        [NameInMap("RenewDuration")]
        [Validation(Required=false)]
        public int? RenewDuration { get; set; }

        /// <summary>
        /// 付费时长单位。
        /// </summary>
        [NameInMap("RenewDurationUnit")]
        [Validation(Required=false)]
        public string RenewDurationUnit { get; set; }

    }

}
