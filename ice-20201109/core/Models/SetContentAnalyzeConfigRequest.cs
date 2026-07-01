// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetContentAnalyzeConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically start Intelligent Content Analysis after a Media Asset is registered.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable (Default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

        /// <summary>
        /// <para>The storage type for analysis results. This parameter applies only when Auto is set to true. Default: Empty.</para>
        /// <list type="bullet">
        /// <item><description><para>TEXT: Label</para>
        /// </description></item>
        /// <item><description><para>FACE: Face</para>
        /// </description></item>
        /// <item><description><para>DNA: Similar Image</para>
        /// </description></item>
        /// </list>
        /// <para>You can specify multiple values separated by commas. If this parameter is empty, Intelligent Content Analysis results are not saved to any search library, and you cannot perform content searches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT,FACE</para>
        /// </summary>
        [NameInMap("SaveType")]
        [Validation(Required=false)]
        public string SaveType { get; set; }

        /// <summary>
        /// <para>The ID of the Intelligent Content Analysis Template. Each Template includes the following AI analysis features:</para>
        /// <list type="bullet">
        /// <item><description><para>S00000101-100040: Text Recognition</para>
        /// </description></item>
        /// <item><description><para>S00000101-100060: Video Categorization and Face Recognition</para>
        /// </description></item>
        /// <item><description><para>S00000101-100070: Text Recognition, Video Categorization, and Face Recognition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>S00000101-100070</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
