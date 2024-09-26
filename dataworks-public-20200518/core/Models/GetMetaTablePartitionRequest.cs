// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.</para>
        /// <para>You can log on to the <a href="https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou">EMR console</a> to obtain the ID.</para>
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
        /// <para>The name of the database. This parameter is required only if you set the DataSourceType parameter to emr.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2780105.html">ListMetaDB</a> operation to query the name of the metadatabase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

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
        /// <para>The logic for sorting partitions in the metatable.</para>
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public GetMetaTablePartitionRequestSortCriterion SortCriterion { get; set; }
        public class GetMetaTablePartitionRequestSortCriterion : TeaModel {
            /// <summary>
            /// <para>The order in which partitions in the metatable are sorted. Valid values: asc and desc. Default value: desc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <para>The field that is used to sort partitions in the metatable. Valid values: name and modify_time. By default, partitions in the metatable are sorted based on their creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("SortField")]
            [Validation(Required=false)]
            public string SortField { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the metatable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the metatable in the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> operation to query the name of the metatable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
