// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.</para>
        /// <para>You can log on to the <a href="https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou">EMR console</a> to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values: odps and emr.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The name of the metadatabase. This parameter is required only if you set the DataSourceType parameter to emr.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2780105.html">ListMetaDB</a> operation to query the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include extended fields in query results. The extended fields include ReadCount, FavoriteCount, and ViewCount. This parameter takes effect only if you set the DataSourceType parameter to odps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public bool? Extension { get; set; }

        /// <summary>
        /// <para>The GUID of the MaxCompute table. Specify the GUID in the odps.projectName.tableName format.</para>
        /// <remarks>
        /// <para>This parameter is optional for E-MapReduce (EMR) tables.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the metatable in the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> operation to query the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
