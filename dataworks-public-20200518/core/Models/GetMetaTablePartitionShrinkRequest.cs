// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can log on to the [EMR console](https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou) to obtain the ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The type of the data source. Valid values: odps and emr.
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The name of the database. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [ListMetaDB](https://help.aliyun.com/document_detail/2780105.html) operation to query the name of the metadatabase.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The logic for sorting partitions in the metatable.
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public string SortCriterionShrink { get; set; }

        /// <summary>
        /// The unique identifier of the metatable.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The name of the metatable in the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [GetMetaDBTableList](https://help.aliyun.com/document_detail/2780086.html) operation to query the name of the metatable.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
