// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EMR cluster. Required only if <b>DataSourceType</b> is <b>EMR</b>.</para>
        /// <para>Log on to the <a href="https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou">EMR console</a> to obtain the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values: ODPS and EMR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The name of the database. Required only if <b>DataSourceType</b> is <b>EMR</b>.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2780105.html">ListMetaDB</a> operation to query the database name.</para>
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
        /// <para>The partition sorting logic.</para>
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public GetMetaTablePartitionRequestSortCriterion SortCriterion { get; set; }
        public class GetMetaTablePartitionRequestSortCriterion : TeaModel {
            /// <summary>
            /// <para>The sort order. Valid values: <b>asc</b> and <b>desc</b>. Default value: <b>desc</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <para>The field used to sort the partitions. Valid values: <b>name</b> and <b>modify_time</b>. Default value: the creation time of the partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("SortField")]
            [Validation(Required=false)]
            public string SortField { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the EMR table. Required only if <b>DataSourceType</b> is <b>EMR</b>.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> operation to query the table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
