// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RescaleApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Specifies whether to automatically enable an auto scaling policy for the application. Take note of the following rules:
        /// 
        /// *   **true**: turns on Logon-free Sharing
        /// *   **false**: turns off Logon-free Sharing
        /// </summary>
        [NameInMap("AutoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        /// <summary>
        /// The percentage of the minimum number of available instances. Take note of the following rules:
        /// 
        /// *   If you set the value to **-1**, the minimum number of available instances is not determined based on this parameter. Default value: -1.
        /// *   If you set the value to a number **from 0 to 100**, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if the percentage is set to **50**% and five instances are available, the minimum number of available instances is 3.
        /// 
        /// > When **MinReadyInstance** and **MinReadyInstanceRatio** are specified and **MinReadyInstanceRatio** is set to a number from 0 to 100, the value of MinReadyInstanceRatio** takes precedence.**** For example, if **MinReadyInstances** is set to **5, and **MinReadyInstanceRatio** is set to **50**, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × **50%**.
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// The minimum number of available instances. Special values:
        /// 
        /// *   If you set the value to **0**, business interruptions occur when the application is updated.
        /// *   If you set the value to \\*\\*-1\\*\\*, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.
        /// 
        /// > Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// The expected number of instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
