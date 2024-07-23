// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media workflow that you want to update. To obtain the ID of the media workflow, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Workflows</b> &gt; <b>Workflow Settings</b> in the left-side navigation pane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6307eb0d3f85477882d205aa040f****</para>
        /// </summary>
        [NameInMap("MediaWorkflowId")]
        [Validation(Required=false)]
        public string MediaWorkflowId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The new topology of the media workflow. The value is a JSON object that contains the activity list and activity dependencies.</para>
        /// <remarks>
        /// <para>The Object Storage Service (OSS) bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
