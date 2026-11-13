// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the connection string. Valid values:</para>
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
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The environment to which the data source belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Development environment.</description></item>
        /// <item><description>1: Production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The name of the data source to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number for the paging query. Valid values: integers greater than or equal to 1.</para>
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
        /// <para>The ID of the workspace to which the data source belongs. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76086</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The status of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED: Normal.</description></item>
        /// <item><description>DISABLED: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The subtype of the connection string. This parameter applies to scenarios where a parent type contains subtypes. The following combinations are supported:</para>
        /// <list type="bullet">
        /// <item><description>Parent type: <c>rds</c></description></item>
        /// <item><description>Subtypes: <c>mysql</c>, <c>sqlserver</c>, or <c>postgresql</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}
