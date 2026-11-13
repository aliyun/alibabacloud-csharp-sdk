// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFilesRequest : TeaModel {
        /// <summary>
        /// <para>The file name for exact match. The file name in the query result must be an exact match with the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_create.sql</para>
        /// </summary>
        [NameInMap("ExactFileName")]
        [Validation(Required=false)]
        public string ExactFileName { get; set; }

        /// <summary>
        /// <para>The path of the folder where the file resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/my_first_business_process/MaxCompute/ods_layer</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The list of file IDs. The file IDs in the query result must be a subset of the IDs in this list. You can specify up to 50 file IDs at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78237,816123</para>
        /// </summary>
        [NameInMap("FileIdIn")]
        [Validation(Required=false)]
        public string FileIdIn { get; set; }

        /// <summary>
        /// <para>The file type. The code varies by file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks node types</a>. Specifies the code type of the file to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10,23</para>
        /// </summary>
        [NameInMap("FileTypes")]
        [Validation(Required=false)]
        public string FileTypes { get; set; }

        /// <summary>
        /// <para>The keyword in the file name. Fuzzy match is supported. You can enter a keyword to query all files whose names contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud user ID of the user who last edited the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38748246285727</para>
        /// </summary>
        [NameInMap("LastEditUser")]
        [Validation(Required=false)]
        public string LastEditUser { get; set; }

        /// <summary>
        /// <para>Specifies whether the query result includes the path of the folder where the file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAbsoluteFolderPath")]
        [Validation(Required=false)]
        public bool? NeedAbsoluteFolderPath { get; set; }

        /// <summary>
        /// <para>Specifies whether the query result includes the file content. For files with a large amount of content, network transmission latency may be high.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedContent")]
        [Validation(Required=false)]
        public bool? NeedContent { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled node. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to obtain the node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123541234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The owner of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// <para>You must specify either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace for the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace name.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The functional module to which the file belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Data Studio.</description></item>
        /// <item><description>MANUAL: Manual task.</description></item>
        /// <item><description>MANUAL_BIZ: Manual business flow.</description></item>
        /// <item><description>SKIP: Dry-run scheduling in Data Studio.</description></item>
        /// <item><description>ADHOCQUERY: Ad hoc query.</description></item>
        /// <item><description>COMPONENT: Component management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("UseType")]
        [Validation(Required=false)]
        public string UseType { get; set; }

    }

}
