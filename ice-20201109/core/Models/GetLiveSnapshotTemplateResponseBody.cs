// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveSnapshotTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the configuration was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T22:22:22Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T22:22:22Z</para>
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// <para>The naming format of the snapshot captured in overwrite mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}.jpg</para>
        /// </summary>
        [NameInMap("OverwriteFormat")]
        [Validation(Required=false)]
        public string OverwriteFormat { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The naming format of the snapshot captured in time series mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("SequenceFormat")]
        [Validation(Required=false)]
        public string SequenceFormat { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The interval between two adjacent snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public int? TimeInterval { get; set; }

        /// <summary>
        /// <para>The type of the template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system</description></item>
        /// <item><description>custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
