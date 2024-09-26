// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsRequest : TeaModel {
        /// <summary>
        /// <para>The time when the on-duty engineer starts a shift. Set the value to a UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593950832000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The time when the on-duty engineer ends a shift. Set the value to a UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593950832000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You can log on to the DataWorks console and move the pointer over the profile picture in the upper-right corner to view the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1933790****551</para>
        /// </summary>
        [NameInMap("ShiftPersonUID")]
        [Validation(Required=false)]
        public string ShiftPersonUID { get; set; }

        /// <summary>
        /// <para>The unique identifier of the shift schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab6456ada634b2f938ee******9b45b</para>
        /// </summary>
        [NameInMap("ShiftScheduleIdentifier")]
        [Validation(Required=false)]
        public string ShiftScheduleIdentifier { get; set; }

        /// <summary>
        /// <para>The type of the on-duty engineer that you want to query. Valid values: ALL, PRIMARY, BACKUP, and DESIGNATED_USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
