// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return original request parameters specified to create the task.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <para>This parameter applies only to the following tasks:</para>
        /// <list type="bullet">
        /// <item><description>MediaConvert</description></item>
        /// <item><description>VideoLabelClassification</description></item>
        /// <item><description>FaceClustering</description></item>
        /// <item><description>FileCompression</description></item>
        /// <item><description>ArchiveFileInspection</description></item>
        /// <item><description>FileUncompression</description></item>
        /// <item><description>PointCloudCompress</description></item>
        /// <item><description>ImageToPDF</description></item>
        /// <item><description>StoryCreation</description></item>
        /// <item><description>LocationDateClustering</description></item>
        /// <item><description>ImageSplicing</description></item>
        /// <item><description>FacesSearching</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("RequestDefinition")]
        [Validation(Required=false)]
        public bool? RequestDefinition { get; set; }

        /// <summary>
        /// <para>The ID of the task. You can obtain the ID of a task after you create the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2b277b9-0d30-4882-ad6d-ad661382****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the task. For information about valid values, see <a href="https://help.aliyun.com/document_detail/2743993.html">Task types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoLabelClassification</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
