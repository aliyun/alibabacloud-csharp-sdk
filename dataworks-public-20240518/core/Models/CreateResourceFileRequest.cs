// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceFileRequest : TeaModel {
        /// <summary>
        /// <para>The code for the file. The code format varies based on the file type. To view the code format for a specific file type, go to Operation Center, open the directed acyclic graph (DAG) of a node of the file type, right-click the node, and then select View Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The description of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description</para>
        /// </summary>
        [NameInMap("FileDescription")]
        [Validation(Required=false)]
        public string FileDescription { get; set; }

        /// <summary>
        /// <para>The path of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/MaxCompute/Folder_1/Folder_2</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Filename</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The type of the code for the file.</para>
        /// <para>The code for files varies based on the file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>. You can call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the type of the code for the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// <para>The name of the original resource file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin_file_name.sql</para>
        /// </summary>
        [NameInMap("OriginResourceName")]
        [Validation(Required=false)]
        public string OriginResourceName { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the file owner. If this parameter is not configured, the ID of the Alibaba Cloud account of the user who calls the operation is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the Workspace page to query the ID. You must configure this parameter to specify the DataWorks workspace to which the operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies whether to upload the resource file to a desired compute engine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegisterToCalcEngine")]
        [Validation(Required=false)]
        public bool? RegisterToCalcEngine { get; set; }

        /// <summary>
        /// <para>The URL of the Object Storage Service (OSS) bucket to which you upload the file. The URL is provided by the POP platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucketname1.oss-cn-shanghai.aliyuncs.com/example">http://bucketname1.oss-cn-shanghai.aliyuncs.com/example</a></para>
        /// </summary>
        [NameInMap("ResourceFile")]
        [Validation(Required=false)]
        public string ResourceFile { get; set; }

        /// <summary>
        /// <para>The storage path of the resource file in a desired compute engine. This parameter takes effect only for E-MapReduce (EMR) and Cloudera\&quot;s Distribution including Apache Hadoop (CDH) compute engines. In an EMR compute engine, this parameter is configured in the [osshdfs]://path/to/object format. In a CDH compute engine, this parameter is set to /user/admin/lib by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://oss-cn-shanghai.aliyuncs.com/emr-test</para>
        /// </summary>
        [NameInMap("StorageURL")]
        [Validation(Required=false)]
        public string StorageURL { get; set; }

        /// <summary>
        /// <para>The upload mode of MaxCompute file resources. This parameter takes effect only for MaxCompute file resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: indicates the resource upload and download mode.</description></item>
        /// <item><description>false: indicates the online editing mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UploadMode")]
        [Validation(Required=false)]
        public bool? UploadMode { get; set; }

    }

}
