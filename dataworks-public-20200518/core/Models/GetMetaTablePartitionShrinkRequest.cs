// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionShrinkRequest : TeaModel {
        /// <summary>
        /// The name of the metatable in the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [GetMetaDBTableList](https://help.aliyun.com/document_detail/173916.html) operation to query the name of the metatable.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The field that is used to sort partitions in the metatable. Valid values: name and modify_time.
        /// 
        /// By default, partitions in the metatable are sorted based on their creation time.
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The type of the data source. Valid values: odps and emr.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The GUID of the metatable.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can log on to the [EMR console](https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou) to obtain the ID of the EMR cluster.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The order in which partitions in the metatable are sorted. Valid values: asc and desc. Default value: desc.
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public string SortCriterionShrink { get; set; }

        /// <summary>
        /// The name of the metadatabase. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [ListMetaDB](https://help.aliyun.com/document_detail/185662.html) operation to query the name of the metadatabase.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The logic for sorting partitions in the metatable.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
