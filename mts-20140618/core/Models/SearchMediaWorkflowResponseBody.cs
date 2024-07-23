// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchMediaWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media workflows.</para>
        /// </summary>
        [NameInMap("MediaWorkflowList")]
        [Validation(Required=false)]
        public SearchMediaWorkflowResponseBodyMediaWorkflowList MediaWorkflowList { get; set; }
        public class SearchMediaWorkflowResponseBodyMediaWorkflowList : TeaModel {
            [NameInMap("MediaWorkflow")]
            [Validation(Required=false)]
            public List<SearchMediaWorkflowResponseBodyMediaWorkflowListMediaWorkflow> MediaWorkflow { get; set; }
            public class SearchMediaWorkflowResponseBodyMediaWorkflowListMediaWorkflow : TeaModel {
                /// <summary>
                /// <para>The time when the media workflow was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-04-01T05:38:41Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the media workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e4578645b665e2a12****</para>
                /// </summary>
                [NameInMap("MediaWorkflowId")]
                [Validation(Required=false)]
                public string MediaWorkflowId { get; set; }

                /// <summary>
                /// <para>The name of the media workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-mediaworkflow-****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the media workflow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Inactive</b>: The media workflow is deactivated.</description></item>
                /// <item><description><b>Active</b>: The media workflow is activated.</description></item>
                /// <item><description><b>Deleted</b>: The media workflow is deleted.</description></item>
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
                /// <para>{&quot;MediaWorkflowList&quot;:{&quot;MediaWorkflow&quot;:[{&quot;CreationTime&quot;:&quot;2016-04-01T05:29:38Z&quot;,&quot;Name&quot;:&quot;example-mediaworkflow-<b><b>&quot;,&quot;State&quot;:&quot;Active&quot;,&quot;Topology&quot;:&quot;{\&quot;Activities\&quot;:{\&quot;Act-Start\&quot;:{\&quot;Parameters\&quot;:{\&quot;PipelineId\&quot;:\&quot;130266f58161436a80bf07cb12c8</b></b>\&quot;,\&quot;InputFile\&quot;:\&quot;{\\\&quot;Bucket\\\&quot;: \\\&quot;example-bucket-<b><b>\\\&quot;,\\\&quot;Location\\\&quot;: \\\&quot;example-location\\\&quot;}\&quot;},\&quot;Type\&quot;:\&quot;Start\&quot;},\&quot;Act-Report\&quot;:{\&quot;Parameters\&quot;:{},\&quot;Type\&quot;:\&quot;Report\&quot;},\&quot;Act-Transcode-M3U8\&quot;:{\&quot;Parameters\&quot;:{\&quot;Outputs\&quot;:\&quot;[{\\\&quot;Object\\\&quot;:\\\&quot;transcode/{ObjectPrefix}{FileName}\\\&quot;,\\\&quot;TemplateId\\\&quot;: \\\&quot;957d1719ee85ed6527b90cf62726</b></b>\\\&quot;}]\&quot;,\&quot;OutputBucket\&quot;:\&quot;example-bucket-<b><b>\&quot;,\&quot;OutputLocation\&quot;:\&quot;example-location\&quot;},\&quot;Type\&quot;:\&quot;Transcode\&quot;}},\&quot;Dependencies\&quot;:{\&quot;Act-Start\&quot;:[\&quot;Act-Transcode-M3U8\&quot;],\&quot;Act-Report\&quot;:[],\&quot;Act-Transcode-M3U8\&quot;:[\&quot;Act-Report\&quot;]}}&quot;,&quot;MediaWorkflowId&quot;:&quot;93ab850b4f6f44eab54b6e91d24d</b></b>&quot;}]},&quot;RequestId&quot;:&quot;16CD0CDD-457E-420D-9755-8385075A1234&quot;}</para>
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

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16CD0CDD-457E-420D-9755-8385075A1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
