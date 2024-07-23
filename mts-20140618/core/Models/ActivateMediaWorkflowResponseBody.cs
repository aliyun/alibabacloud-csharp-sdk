// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ActivateMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media workflow.</para>
        /// </summary>
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public ActivateMediaWorkflowResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class ActivateMediaWorkflowResponseBodyMediaWorkflow : TeaModel {
            /// <summary>
            /// <para>The time when the media workflow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-04-01T05:29:37Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the media workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93ab850b4f6f44eab54b6e9181d4****</para>
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
            /// <para>The status of the media workflow. The value is <b>Active</b>.</para>
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
            /// <para>{\&quot;Activities\&quot;:{\&quot;Act-Start\&quot;:{\&quot;Parameters\&quot;:{\&quot;PipelineId\&quot;:\&quot;130266f58161436a80bf07cb12c8****\&quot;,\&quot;InputFile\&quot;:\&quot;{\\\&quot;Bucket\\\&quot;: \\\&quot;example\\\&quot;,\\\&quot;Location\\\&quot;: \\\&quot;oss-cn-hangzhou\\\&quot;}\&quot;},\&quot;Type\&quot;:\&quot;Start\&quot;},\&quot;Act-Report\&quot;:{\&quot;Parameters\&quot;:{},\&quot;Type\&quot;:\&quot;Report\&quot;},\&quot;Act-Transcode-M3U8\&quot;:{\&quot;Parameters\&quot;:{\&quot;Outputs\&quot;:\&quot;[{\\\&quot;OutputObject\\\&quot;:\\\&quot;transcode%2F%7BObjectPrefix%7D%7BFileName%7D\\\&quot;,\\\&quot;TemplateId\\\&quot;: \\\&quot;957d1719ee85ed6527b90cf62726****\\\&quot;}]\&quot;,\&quot;OutputBucket\&quot;:\&quot;panda-vod-hls\&quot;,\&quot;OutputLocation\&quot;:\&quot;oss-cn-hangzhou\&quot;},\&quot;Type\&quot;:\&quot;Transcode\&quot;}},\&quot;Dependencies\&quot;:{\&quot;Act-Start\&quot;:[\&quot;Act-Transcode-M3U8\&quot;],\&quot;Act-Report\&quot;:[],\&quot;Act-Transcode-M3U8\&quot;:[\&quot;Act-Report\&quot;]}}</para>
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public string Topology { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1326BD4-30B1-4CB6-Q123-3330B877B0D4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
