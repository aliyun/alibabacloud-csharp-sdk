// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// The directory to which the data file is mounted. The value must be a full path and cannot be \"/../\". Example: \["/data/app01", "/data/user"]. Specify the relative path of the virtual device for this parameter. For example, specify /data for this parameter when the actual path of the virtual device is /data/{input path}.
        /// </summary>
        [NameInMap("Directorys")]
        [Validation(Required=false)]
        public string Directorys { get; set; }

        /// <summary>
        /// The parameter does not take effect.
        /// </summary>
        [NameInMap("PodConfigName")]
        [Validation(Required=false)]
        public string PodConfigName { get; set; }

        /// <summary>
        /// The maximum duration for locking an idle device. Unit: seconds. This parameter takes effect only if you set ServiceAction to PreSchedule. Default value: 300.
        /// </summary>
        [NameInMap("PreLockedTimeout")]
        [Validation(Required=false)]
        public int? PreLockedTimeout { get; set; }

        /// <summary>
        /// The scheduling policy of the device. The value must be a JSON string.
        /// </summary>
        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        /// <summary>
        /// The scheduling operation. The value must be of the enumeration type. Valid values:
        /// 
        /// Container scenario:
        /// 
        /// *   Start: selects and activates an idle cloud device.
        /// *   Stop: stops and releases the cloud device.
        /// *   Console: performs the scheduling operation when the device is in the scheduling state.
        /// 
        /// Bare metal instance or virtual machine scenario:
        /// 
        /// *   PreSchedule: locks a virtual machine instance for scheduling.
        /// *   Confirm: confirms the scheduling operation.
        /// *   Cancel: cancels the scheduling operation.
        /// *   Console: performs the scheduling operation when the device is in the scheduling state.
        /// </summary>
        [NameInMap("ServiceAction")]
        [Validation(Required=false)]
        public string ServiceAction { get; set; }

        /// <summary>
        /// The service commands. The value must be a JSON string.
        /// </summary>
        [NameInMap("ServiceCommands")]
        [Validation(Required=false)]
        public string ServiceCommands { get; set; }

        /// <summary>
        /// The UUID of the device.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
