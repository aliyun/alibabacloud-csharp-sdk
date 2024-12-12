// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveSnapshotTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The naming format of the snapshot captured in overwrite mode.</para>
        /// <list type="bullet">
        /// <item><description>The value cannot start with a forward slash (/). Only the suffix .jpg is supported.</description></item>
        /// <item><description>The value cannot exceed 255 characters in length.</description></item>
        /// <item><description>The {JobId} placeholder is supported. It specifies the ID of the snapshot job.</description></item>
        /// <item><description>Placeholders such as {UnixTimestamp}, {Sequence}, and {Date} are not allowed.</description></item>
        /// <item><description>You must specify at least one of the OverwriteFormat and SequenceFormat parameters.</description></item>
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
        /// <item><description>The value cannot start with a forward slash (/). Only the suffix .jpg is supported.</description></item>
        /// <item><description>The value cannot exceed 255 characters in length.</description></item>
        /// <item><description>The {JobId}, {Date}, {UnixTimestamp}, and {Sequence} placeholders are supported. {JobId} specifies the ID of the snapshot job. {Date} specifies the date on which the snapshot is captured. {UnixTimestamp} specifies the timestamp of the snapshot. {Sequence} specifies the sequence number of the snapshot. You must specify at least one of the {UnixTimestamp} and {Sequence} placeholders.</description></item>
        /// <item><description>You must specify at least one of the OverwriteFormat and SequenceFormat parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("SequenceFormat")]
        [Validation(Required=false)]
        public string SequenceFormat { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
