// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDataSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>odps</description></item>
        /// <item><description>mysql</description></item>
        /// <item><description>rds</description></item>
        /// <item><description>oss</description></item>
        /// <item><description>sqlserver</description></item>
        /// <item><description>polardb</description></item>
        /// <item><description>oracle</description></item>
        /// <item><description>mongodb</description></item>
        /// <item><description>emr</description></item>
        /// <item><description>postgresql</description></item>
        /// <item><description>analyticdb_for_mysql</description></item>
        /// <item><description>hybriddb_for_postgresql</description></item>
        /// <item><description>holo</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The environment in which the data source resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: development environment</description></item>
        /// <item><description>1: production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The keyword contained in the names of the data sources that you want to export. You can specify only one keyword. For example, if you set this parameter to test, you can call the ExportDataSources operation to export all data sources whose names contain test in the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
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
        /// <para>The ID of the DataWorks workspace to which the data sources belong. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to query the ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The subtype of the data source. This parameter takes effect only when the DataSourceType parameter is set to rds.</para>
        /// <para>If the value of the DataSourceType parameter is rds, the value of this parameter can be mysql, sqlserver, or postgresql.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}
