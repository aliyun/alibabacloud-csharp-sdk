// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SearchMetaTablesRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the workspace to which the table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name</para>
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// <para>The ID of the EMR cluster. This parameter is required only when the data source type is EMR.</para>
        /// <para>You can log on to the <a href="https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou">EMR console</a> to obtain the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values: ODPS and emr.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The type of the table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: table.</description></item>
        /// <item><description>1: view.
        /// If you do not specify this parameter, tables of all types are searched by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public int? EntityType { get; set; }

        /// <summary>
        /// <para>The keyword used to search for table names by using a tokenization matching algorithm. If no matching field is found, null is returned. By default, the search is performed based on underscore tokenization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number for the paging query.</para>
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
        /// <para>The schema information of the table. If the three-level model is enabled for MaxCompute, you must specify the schema information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

    }

}
