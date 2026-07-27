// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityEntityRequest : TeaModel {
        /// <summary>
        /// <para>The type of the engine or data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cdh</c></para>
        /// </description></item>
        /// <item><description><para><c>analyticdb_for_mysql</c></para>
        /// </description></item>
        /// <item><description><para><c>odps</c></para>
        /// </description></item>
        /// <item><description><para><c>emr</c></para>
        /// </description></item>
        /// <item><description><para><c>hadoop</c></para>
        /// </description></item>
        /// <item><description><para><c>holodb</c></para>
        /// </description></item>
        /// <item><description><para><c>hybriddb_for_postgresql</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The partition expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("MatchExpression")]
        [Validation(Required=false)]
        public string MatchExpression { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. To find the workspace ID, log in to the <a href="https://workbench.data.aliyun.com/console">DataWorks Console</a> and go to the Workspace Configurations page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the engine or data source. You can find this name on the Data Source Configuration page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The name of the partitioned table. You can call the <a href="https://help.aliyun.com/document_detail/173923.html">GetMetaTablePartition</a> operation to get the table name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dual</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
