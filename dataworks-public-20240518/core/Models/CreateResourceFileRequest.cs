// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceFileRequest : TeaModel {
        /// <summary>
        /// <para>The code content of the file. The code format varies depending on the code type (fileType). You can locate a job of the corresponding type in the Operation Center, right-click it, and select View Code to check the specific code format.</para>
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
        /// <para>The code type of the file.</para>
        /// <para>Different file types correspond to different code types. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks Node Types</a>.<br>
        /// You can also invoke the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> API to query the code types of files.</para>
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
        /// <para>The Alibaba Cloud User ID of the file owner. If this parameter is empty, the Alibaba Cloud User ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console, go to the workspace configuration page, and obtain the workspace ID. This parameter is required to identify the DataWorks workspace for this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Indicates whether to synchronize and upload the resource to the compute engine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegisterToCalcEngine")]
        [Validation(Required=false)]
        public bool? RegisterToCalcEngine { get; set; }

        /// <summary>
        /// <para>The OSS URL for file upload provided by POP.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucketname1.oss-cn-shanghai.aliyuncs.com/example">http://bucketname1.oss-cn-shanghai.aliyuncs.com/example</a></para>
        /// </summary>
        [NameInMap("ResourceFile")]
        [Validation(Required=false)]
        public string ResourceFile { get; set; }

        /// <summary>
        /// <para>The Storage Path of the resource file on the compute engine. This field is currently used only by EMR and CDH. The EMR format is [osshdfs]://path/to/object, and for CDH, the default value must be /user/admin/lib.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://oss-cn-shanghai.aliyuncs.com/emr-test</para>
        /// </summary>
        [NameInMap("StorageURL")]
        [Validation(Required=false)]
        public string StorageURL { get; set; }

        /// <summary>
        /// <para>The upload mode for the resource file. This parameter currently applies only to File-type files in MaxCompute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Downloadable resource mode.</para>
        /// </description></item>
        /// <item><description><para>false: Online-editable text mode.</para>
        /// </description></item>
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
