// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the media workflow.</para>
        /// </summary>
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public UpdateMediaWorkflowResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class UpdateMediaWorkflowResponseBodyMediaWorkflow : TeaModel {
            /// <summary>
            /// <para>The time when the media workflow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-04-01T05:29:38Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the media workflow that is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6307eb0d3f85477882d205aa040f****</para>
            /// </summary>
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public string MediaWorkflowId { get; set; }

            /// <summary>
            /// <para>The name of the media workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>examp-mediaworkflow-****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The state of the media workflow. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Inactive</b>: The media workflow is disabled.</description></item>
            /// <item><description><b>Active</b>: The media workflow is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The topology of the media workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;Activities&quot;: {
            ///             &quot;Act-Start&quot;: {
            ///                   &quot;Parameters&quot;: {
            ///                         &quot;PipelineId&quot;: &quot;130266f58161436a80bf07cb12c8****&quot;,
            ///                         &quot;InputFile&quot;: &quot;{\&quot;Bucket\&quot;: \&quot;example-bucket-<b><b>\&quot;,\&quot;Location\&quot;: \&quot;cn-shanghai\&quot;}&quot;
            ///                   },
            ///                   &quot;Type&quot;: &quot;Start&quot;
            ///             },
            ///             &quot;Act-Report&quot;: {
            ///                   &quot;Parameters&quot;: {},
            ///                   &quot;Type&quot;: &quot;Report&quot;
            ///             },
            ///             &quot;Act-Transcode-M3U8&quot;: {
            ///                   &quot;Parameters&quot;: {
            ///                         &quot;Outputs&quot;: &quot;[{\&quot;Object\&quot;:\&quot;transcode/{ObjectPrefix}{FileName}\&quot;,\&quot;TemplateId\&quot;: \&quot;957d1719ee85ed6527b90cf62726</b></b>\&quot;}]&quot;,
            ///                         &quot;OutputBucket&quot;: &quot;example-bucket-****&quot;,
            ///                         &quot;OutputLocation&quot;: &quot;cn-shanghai&quot;
            ///                   },
            ///                   &quot;Type&quot;: &quot;Transcode&quot;
            ///             }
            ///       },
            ///       &quot;Dependencies&quot;: {
            ///             &quot;Act-Start&quot;: [
            ///                   &quot;Act-Transcode-M3U8&quot;
            ///             ],
            ///             &quot;Act-Report&quot;: [],
            ///             &quot;Act-Transcode-M3U8&quot;: [
            ///                   &quot;Act-Report&quot;
            ///             ]
            ///       }
            /// }</para>
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public string Topology { get; set; }

            /// <summary>
            /// <para>The trigger mode of the media workflow. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OssAutoTrigger</b>: The media workflow is automatically triggered.</description></item>
            /// <item><description><b>NotInAuto</b>: The media workflow is not automatically triggered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OssAutoTrigger</para>
            /// </summary>
            [NameInMap("TriggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D752035-97DA-54E5-88E2-E8405EEA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
