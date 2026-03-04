// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputGroupOutput : TeaModel {
        /// <summary>
        /// <para>The feature parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public string Features { get; set; }

        /// <summary>
        /// <para>A name to label this output. This is for identification purposes only and does not affect the filename.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group-output</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The filename for this output. This path is relative to OutputFileBase defined in MediaConvertOutputGroupConfig. The final output path is {OutputFileBase}/{OutputFileName}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720p.mp4</para>
        /// </summary>
        [NameInMap("OutputFileName")]
        [Validation(Required=false)]
        public string OutputFileName { get; set; }

        /// <summary>
        /// <para>A JSON string containing parameters to override the settings from the associated transcoding template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// <para>The processing priority for this output. Valid values: 1 to 10. A higher value indicates higher priority. Default value: 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
