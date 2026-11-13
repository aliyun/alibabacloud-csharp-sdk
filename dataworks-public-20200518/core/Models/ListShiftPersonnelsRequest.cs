// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the on-call shift. The value is a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593950832000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the on-call shift. The value is a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593950832000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID. You can log on to the DataWorks console and move the pointer over the profile picture in the upper-right corner of the top menu bar to view the account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1933790****551</para>
        /// </summary>
        [NameInMap("ShiftPersonUID")]
        [Validation(Required=false)]
        public string ShiftPersonUID { get; set; }

        /// <summary>
        /// <para>The unique identifier of the shift schedule. You can call the ListShiftSchedules operation to query existing shift schedules and obtain a valid ShiftScheduleIdentifier from the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab6456ada634b2f938ee******9b45b</para>
        /// </summary>
        [NameInMap("ShiftScheduleIdentifier")]
        [Validation(Required=false)]
        public string ShiftScheduleIdentifier { get; set; }

        /// <summary>
        /// <para>The query condition for on-call personnel. Valid values: ALL (all on-call personnel), PRIMARY (primary on-call personnel), BACKUP (backup on-call personnel), and DESIGNATED_USER (designated user).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
