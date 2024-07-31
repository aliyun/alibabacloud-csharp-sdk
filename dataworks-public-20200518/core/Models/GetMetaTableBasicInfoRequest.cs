// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableBasicInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can log on to the [EMR console](https://emr.console.aliyun.com/?spm=a2c4g.11186623.0.0.965cc5c2GeiHet#/cn-hangzhou) to query the ID.
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
        /// The name of the metadatabase. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [ListMetaDB](https://help.aliyun.com/document_detail/2780105.html) operation to query the name.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Specifies whether to include extended fields in query results. The extended fields include ReadCount, FavoriteCount, and ViewCount. This parameter takes effect only if you set the DataSourceType parameter to odps.
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public bool? Extension { get; set; }

        /// <summary>
        /// The GUID of the MaxCompute table. Specify the GUID in the odps.projectName.tableName format.
        /// 
        /// > This parameter is optional for E-MapReduce (EMR) tables.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The name of the metatable in the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [GetMetaDBTableList](https://help.aliyun.com/document_detail/2780086.html) operation to query the name.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
