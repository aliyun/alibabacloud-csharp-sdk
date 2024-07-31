// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsRequest : TeaModel {
        /// <summary>
        /// The time when the on-duty engineer starts a shift. Set the value to a UNIX timestamp.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The time when the on-duty engineer ends a shift. Set the value to a UNIX timestamp.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account. You can log on to the DataWorks console and move the pointer over the profile picture in the upper-right corner to view the ID.
        /// </summary>
        [NameInMap("ShiftPersonUID")]
        [Validation(Required=false)]
        public string ShiftPersonUID { get; set; }

        /// <summary>
        /// The unique identifier of the shift schedule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ShiftScheduleIdentifier")]
        [Validation(Required=false)]
        public string ShiftScheduleIdentifier { get; set; }

        /// <summary>
        /// The type of the on-duty engineer that you want to query. Valid values: ALL, PRIMARY, BACKUP, and DESIGNATED_USER.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
