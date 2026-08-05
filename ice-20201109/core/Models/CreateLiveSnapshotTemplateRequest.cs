// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveSnapshotTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The overwrite snapshot file format.</para>
        /// <list type="bullet">
        /// <item><description>The value cannot start with &quot;/&quot;. Only the .jpg suffix is supported.</description></item>
        /// <item><description>Maximum length: 255.</description></item>
        /// <item><description>Supported placeholder: {JobId}: snapshot task ID.</description></item>
        /// <item><description>The placeholders {UnixTimestamp}, {Sequence}, and {Date} are not allowed.</description></item>
        /// <item><description>At least one of the overwrite snapshot format or sequence snapshot format must be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}.jpg</para>
        /// </summary>
        [NameInMap("OverwriteFormat")]
        [Validation(Required=false)]
        public string OverwriteFormat { get; set; }

        /// <summary>
        /// <para>The sequence snapshot file format.</para>
        /// <list type="bullet">
        /// <item><description>The value cannot start with &quot;/&quot;. Only the .jpg suffix is supported.</description></item>
        /// <item><description>Maximum length: 255.</description></item>
        /// <item><description>Supported placeholders: {JobId}: snapshot task ID, {Date}: snapshot date, {UnixTimestamp}: timestamp, {Sequence}: serial number. At least one of {UnixTimestamp} or {Sequence} must be specified.</description></item>
        /// <item><description>At least one of the overwrite snapshot format or sequence snapshot format must be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("SequenceFormat")]
        [Validation(Required=false)]
        public string SequenceFormat { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 128.</description></item>
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
        /// <para>The snapshot time interval. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 5 to 3600.</description></item>
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
