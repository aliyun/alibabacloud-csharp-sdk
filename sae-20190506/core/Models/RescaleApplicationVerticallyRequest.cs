// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RescaleApplicationVerticallyRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The destination CPU specification. Unit: millicore.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// The destination memory size. Unit: MB.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        [NameInMap("autoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        [NameInMap("minReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        [NameInMap("minReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

    }

}
