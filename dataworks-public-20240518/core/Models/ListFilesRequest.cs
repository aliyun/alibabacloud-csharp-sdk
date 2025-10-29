// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListFilesRequest : TeaModel {
        /// <summary>
        /// <para>The current commit status of the file. Valid values: 0 (the latest code is not committed) and 1 (the latest code is committed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CommitStatus")]
        [Validation(Required=false)]
        public int? CommitStatus { get; set; }

        /// <summary>
        /// <para>The exact file name. The file name in the query result must exactly match this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_create.sql</para>
        /// </summary>
        [NameInMap("ExactFileName")]
        [Validation(Required=false)]
        public string ExactFileName { get; set; }

        /// <summary>
        /// <para>The path to the folder where the file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/my_first_business_process/MaxCompute/ods_layer</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The list of file IDs. The file IDs in the query result must be a subset of this list. You can specify up to 50 file IDs at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78237,816123</para>
        /// </summary>
        [NameInMap("FileIdIn")]
        [Validation(Required=false)]
        public string FileIdIn { get; set; }

        /// <summary>
        /// <para>The code type of the file.</para>
        /// <para>The code type of the file. Common code types and their corresponding file types include: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 97 (PAI), 98 (Combined node), 99 (Virtual node), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (Real-time sync), 1002 (PAI internal node), 1089 (Cross-tenant node), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (Assignment node), 1106 (ForEach node), 1221 (PyODPS 3).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10,23</para>
        /// </summary>
        [NameInMap("FileTypes")]
        [Validation(Required=false)]
        public string FileTypes { get; set; }

        /// <summary>
        /// <para>The keyword for the file name. Fuzzy match is supported. You can enter a keyword to query all files that contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the user who last updated the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11233***</para>
        /// </summary>
        [NameInMap("LastEditUser")]
        [Validation(Required=false)]
        public string LastEditUser { get; set; }

        /// <summary>
        /// <para>Specifies whether the query result includes the path to the folder where the file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAbsoluteFolderPath")]
        [Validation(Required=false)]
        public bool? NeedAbsoluteFolderPath { get; set; }

        /// <summary>
        /// <para>Specifies whether the query result includes the file content. For files with large content, network transmission delays may occur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedContent")]
        [Validation(Required=false)]
        public bool? NeedContent { get; set; }

        /// <summary>
        /// <para>The ID of the scheduling node. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to obtain the node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123541234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The ID of the file owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the ID.</para>
        /// <para>You must configure either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace name. To obtain the workspace name, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace configuration page.</para>
        /// <para>You must specify either this parameter or ProjectId to identify the target DataWorks workspace for this API call.</para>
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
        /// <item><description>NORMAL: Data Studio</description></item>
        /// <item><description>MANUAL: Manually triggered node</description></item>
        /// <item><description>MANUAL_BIZ: Manually triggered workflow</description></item>
        /// <item><description>SKIP: Dry-run scheduling in Data Studio</description></item>
        /// <item><description>ADHOCQUERY: Ad hoc query</description></item>
        /// <item><description>COMPONENT: Component management</description></item>
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
