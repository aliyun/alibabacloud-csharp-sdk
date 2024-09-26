// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFilesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ods_create.sql</para>
        /// </summary>
        [NameInMap("ExactFileName")]
        [Validation(Required=false)]
        public string ExactFileName { get; set; }

        /// <summary>
        /// <para>The path of the files.</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>78237,816123</para>
        /// </summary>
        [NameInMap("FileIdIn")]
        [Validation(Required=false)]
        public string FileIdIn { get; set; }

        /// <summary>
        /// <para>The types of the code in the files.</para>
        /// <para>Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 97 (PAI), 98 (node group), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1002 (PAI inner node), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), 1106 (for-each), and 1221 (PyODPS 3).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10,23</para>
        /// </summary>
        [NameInMap("FileTypes")]
        [Validation(Required=false)]
        public string FileTypes { get; set; }

        /// <summary>
        /// <para>The keyword in the file names. The keyword is used to perform a fuzzy match. You can specify a keyword to query all files whose names contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAbsoluteFolderPath")]
        [Validation(Required=false)]
        public bool? NeedAbsoluteFolderPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedContent")]
        [Validation(Required=false)]
        public bool? NeedContent { get; set; }

        /// <summary>
        /// <para>The ID of the node that is scheduled. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to query the ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123541234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The owner of the files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// <para>You must configure either the ProjectId or ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace name.</para>
        /// <para>You must configure either the ProjectId or ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The module to which the files belong. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: The files are used for DataStudio.</description></item>
        /// <item><description>MANUAL: The files are used for manually triggered nodes.</description></item>
        /// <item><description>MANUAL_BIZ: The files are used for manually triggered workflows.</description></item>
        /// <item><description>SKIP: The files are used for dry-run nodes in DataStudio.</description></item>
        /// <item><description>ADHOCQUERY: The files are used for ad hoc queries.</description></item>
        /// <item><description>COMPONENT: The files are used for snippets.</description></item>
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
