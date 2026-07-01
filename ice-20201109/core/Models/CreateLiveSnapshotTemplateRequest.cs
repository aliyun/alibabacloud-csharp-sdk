// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveSnapshotTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The naming format of the snapshot captured in overwrite mode.</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot start with a forward slash (/). Only the suffix .jpg is supported.</para>
        /// </description></item>
        /// <item><description><para>It cannot exceed 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The {JobId} placeholder is supported. It specifies the ID of the snapshot job.</para>
        /// </description></item>
        /// <item><description><para>Placeholders such as {UnixTimestamp}, {Sequence}, and {Date} are not allowed.</para>
        /// </description></item>
        /// <item><description><para>You must specify at least one of the OverwriteFormat and SequenceFormat parameters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}.jpg</para>
        /// </summary>
        [NameInMap("OverwriteFormat")]
        [Validation(Required=false)]
        public string OverwriteFormat { get; set; }

        /// <summary>
        /// <para>The naming format of the snapshot captured in time series mode.</para>
        /// <list type="bullet">
        /// <item><description><para>The value cannot start with a forward slash (/). Only the suffix .jpg is supported.</para>
        /// </description></item>
        /// <item><description><para>It cannot exceed 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The {JobId}, {Date}, {UnixTimestamp}, and {Sequence} placeholders are supported. {JobId} specifies the ID of the snapshot job. {Date} specifies the date on which the snapshot is captured. {UnixTimestamp} specifies the timestamp of the snapshot. {Sequence} specifies the sequence number of the snapshot. You must specify at least one of the {UnixTimestamp} and {Sequence} placeholders.</para>
        /// </description></item>
        /// <item><description><para>You must specify at least one of the OverwriteFormat and SequenceFormat parameters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("SequenceFormat")]
        [Validation(Required=false)]
        public string SequenceFormat { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template 1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The interval between two adjacent snapshots. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: [5,3600].</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public int? TimeInterval { get; set; }

    }

}
