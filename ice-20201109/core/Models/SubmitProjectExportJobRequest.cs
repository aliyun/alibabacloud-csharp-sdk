// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitProjectExportJobRequest : TeaModel {
        /// <summary>
        /// <para>The export type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BaseTimeline</b>: exports the timeline.</description></item>
        /// <item><description><b>AdobePremierePro</b>: exports an Adobe Premiere Pro project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BaseTimeline</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The output path for the exported project and generated intermediate files, in JSON format. The export destination only supports OSS. Path fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Bucket</b>: Required. The OSS bucket name.</description></item>
        /// <item><description><b>Prefix</b>: Optional. The path prefix. If not specified, it defaults to the root directory.</description></item>
        /// <item><description><b>Width</b>: Optional. The width of the output. The value must be a positive integer. If not provided, the system automatically calculates the value based on the input project or timeline.</description></item>
        /// <item><description><b>Height</b>: Optional. The height of the output. The value must be a positive integer. If not provided, the system automatically calculates the value based on the input project or timeline.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Bucket&quot;: &quot;example-bucket&quot;,
        ///         &quot;Prefix&quot;: &quot;example_prefix&quot;,
        ///         &quot;Width&quot;: 1920,
        ///         &quot;Height&quot;: 1080
        /// }</para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// <remarks>
        /// <para>Notice: Either ProjectId or Timeline must be provided.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>67ae06542b9b93e0d1c387</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The timeline of the online editing job. For data structure, see <a href="https://help.aliyun.com/document_detail/198823.html">Timeline</a>.</para>
        /// <remarks>
        /// <para>Notice: Either ProjectId or Timeline must be provided.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22,%22Key%22:%22Valuexxx%22%7D">http://xx.xx.xxx&quot;,&quot;Key&quot;:&quot;Valuexxx&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
