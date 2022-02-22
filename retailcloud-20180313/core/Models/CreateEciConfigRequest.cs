// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateEciConfigRequest : TeaModel {
        /// <summary>
        /// appEnvId
        /// </summary>
        [NameInMap("AppEnvId")]
        [Validation(Required=false)]
        public long? AppEnvId { get; set; }

        /// <summary>
        /// eipBandwidth
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// enableEciSchedulePolicy
        /// </summary>
        [NameInMap("EnableEciSchedulePolicy")]
        [Validation(Required=false)]
        public bool? EnableEciSchedulePolicy { get; set; }

        /// <summary>
        /// mirrorCache
        /// </summary>
        [NameInMap("MirrorCache")]
        [Validation(Required=false)]
        public bool? MirrorCache { get; set; }

        /// <summary>
        /// normalInstanceLimit
        /// </summary>
        [NameInMap("NormalInstanceLimit")]
        [Validation(Required=false)]
        public int? NormalInstanceLimit { get; set; }

        /// <summary>
        /// scheduleVirtualNode
        /// </summary>
        [NameInMap("ScheduleVirtualNode")]
        [Validation(Required=false)]
        public bool? ScheduleVirtualNode { get; set; }

    }

}
