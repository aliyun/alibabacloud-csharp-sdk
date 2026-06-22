// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetTaskRequest : TeaModel {
        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the original request parameters used to create the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <para>This parameter takes effect only for the following task types:</para>
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
        /// <item><description>FacesSearching.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequestDefinition")]
        [Validation(Required=false)]
        public bool? RequestDefinition { get; set; }

        /// <summary>
        /// <para>The ID of the task that you want to query. This value is returned when you create the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FileCompression-2f157087-91df-4fda-8c3e-232407ec*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the task. For valid values, see <a href="https://help.aliyun.com/document_detail/2743993.html">Task type list</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FileCompression</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
