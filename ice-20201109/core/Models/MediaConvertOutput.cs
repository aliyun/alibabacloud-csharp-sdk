// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutput : TeaModel {
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
        /// <para>The name of the output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>output-video</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output file.</para>
        /// </summary>
        [NameInMap("OutputFile")]
        [Validation(Required=false)]
        public MediaObject OutputFile { get; set; }

        /// <summary>
        /// <para>A JSON string containing parameters to overwrite the corresponding settings of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// <para>The priority. Valid values: 1 to 10. A larger value indicates a higher priority. Default value: 6.</para>
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
