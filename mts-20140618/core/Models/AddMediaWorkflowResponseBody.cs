// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the media workflow.</para>
        /// </summary>
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public AddMediaWorkflowResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class AddMediaWorkflowResponseBodyMediaWorkflow : TeaModel {
            /// <summary>
            /// <para>The time when the media workflow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>016-04-01T05:29:37Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the media workflow. We recommend that you keep this ID for later operations on this workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e00732b977da427d9177a4deb1aa****</para>
            /// </summary>
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public string MediaWorkflowId { get; set; }

            /// <summary>
            /// <para>The name of the media workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mediaworkflow-example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The state of the media workflow. By default, the created workflow is in the <b>Active</b> state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The topology of the media workflow. The value is a JSON object that contains the activities and activity dependencies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{mediaworkflow&quot;,&quot;State&quot;:&quot;Active&quot;,&quot;Topology&quot;:&quot;{\&quot;Activities\&quot;:{\&quot;Act-Start\&quot;:{\&quot;Parameters\&quot;:{\&quot;PipelineId\&quot;:\&quot;130266f58161436a80bf07cb12c8****\&quot;,\&quot;InputFile\&quot;:\&quot;{\\\&quot;Bucket\\\&quot;: \\\&quot;example-bucket-<b><b>\\\&quot;,\\\&quot;Location\\\&quot;: \\\&quot;cn-shanghai\\\&quot;}\&quot;},\&quot;Type\&quot;:\&quot;Start\&quot;},\&quot;Act-Report\&quot;:{\&quot;Parameters\&quot;:{},\&quot;Type\&quot;:\&quot;Report\&quot;},\&quot;Act-Transcode-M3U8\&quot;:{\&quot;Parameters\&quot;:{\&quot;Outputs\&quot;:\&quot;[{\\\&quot;Object\\\&quot;:\\\&quot;transcode/{ObjectPrefix}{FileName}\\\&quot;,\\\&quot;TemplateId\\\&quot;: \\\&quot;957d1719ee85ed6527b90cf62726</b></b>\\\&quot;}]\&quot;,\&quot;OutputBucket\&quot;:\&quot;example-bucket-<b><b>\&quot;,\&quot;OutputLocation\&quot;:\&quot;cn-shanghai\&quot;},\&quot;Type\&quot;:\&quot;Transcode\&quot;}},\&quot;Dependencies\&quot;:{\&quot;Act-Start\&quot;:[\&quot;Act-Transcode-M3U8\&quot;],\&quot;Act-Report\&quot;:[],\&quot;Act-Transcode-M3U8\&quot;:[\&quot;Act-Report\&quot;]}}&quot;,&quot;MediaWorkflowId&quot;:&quot;93ab850b4f6f44eab54b6e91d24d</b></b>&quot;}]},&quot;RequestId&quot;:&quot;16CD0CDD-457E-420D-9755-8385075A1234&quot;}</para>
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public string Topology { get; set; }

            /// <summary>
            /// <para>The triggering mode of the media workflow. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1D21261-ADB9-406A-1234-491382139D59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
