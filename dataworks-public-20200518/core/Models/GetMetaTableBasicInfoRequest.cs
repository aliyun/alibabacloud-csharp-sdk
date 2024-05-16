// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableBasicInfoRequest : TeaModel {
        /// <summary>
        /// The name of the metatable in the EMR cluster. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [GetMetaDBTableList](https://help.aliyun.com/document_detail/173916.html) operation to query the name of the metatable.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The HTTP status code returned.
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
        /// The error message returned.
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public bool? Extension { get; set; }

        /// <summary>
        /// The name of the metadatabase. This parameter is required only if you set the DataSourceType parameter to emr.
        /// 
        /// You can call the [ListMetaDB](https://help.aliyun.com/document_detail/185662.html) operation to query the name of the metadatabase.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// Specifies whether to include extended fields in query results.
        /// 
        /// The extended fields include ReadCount, FavoriteCount, and ViewCount.
        /// 
        /// This parameter takes effect only if you set the DataSourceType parameter to odps.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
