// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateResourceFileAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The code content of the file. The code format varies based on the file type. You can find a task of the corresponding type in Operation Center, right-click the task, and select View Code to view the specific code format.</para>
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
        /// <para>File name</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The code type of the file. The code varies based on the file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks node types</a>. You can also call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the code type of the file.</para>
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
        /// <para>The Alibaba Cloud user ID of the file owner. If this parameter is left empty, the Alibaba Cloud user ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Management page to obtain the workspace ID. This parameter is used to specify the DataWorks workspace on which the API operation is performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10111</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously upload the resource to the compute engine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegisterToCalcEngine")]
        [Validation(Required=false)]
        public bool? RegisterToCalcEngine { get; set; }

        /// <summary>
        /// <para>The OSS URL provided by POP for uploading the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucketname1.oss-cn-shanghai.aliyuncs.com/example">http://bucketname1.oss-cn-shanghai.aliyuncs.com/example</a></para>
        /// </summary>
        [NameInMap("ResourceFile")]
        [Validation(Required=false)]
        public Stream ResourceFileObject { get; set; }

        /// <summary>
        /// <para>The storage path of the resource file in the compute engine. This parameter is used only for E-MapReduce (EMR) and Cloudera\&quot;s Distribution including Apache Hadoop (CDH). The format for EMR is [oss|hdfs]://path/to/object. For CDH, set this parameter to /user/admin/lib by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://oss-cn-shanghai.aliyuncs.com/emr-test</para>
        /// </summary>
        [NameInMap("StorageURL")]
        [Validation(Required=false)]
        public string StorageURL { get; set; }

        /// <summary>
        /// <para>The upload mode of the file resource. This parameter takes effect only for files of the File type in MaxCompute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: the downloadable resource mode.</description></item>
        /// <item><description>false: the online editing text mode.</description></item>
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
