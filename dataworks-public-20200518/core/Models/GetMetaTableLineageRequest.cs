// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableLineageRequest : TeaModel {
        /// <summary>
        /// The name of the metatable.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The error message.
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
        /// The number of entries to return on each page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The ID of the E-MapReduce (EMR) cluster. Set this parameter only when you query data in an EMR compute engine instance.
        /// </summary>
        [NameInMap("NextPrimaryKey")]
        [Validation(Required=false)]
        public string NextPrimaryKey { get; set; }

        /// <summary>
        /// The name of the metadatabase.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The logic of paging. Set this parameter based on the value of the response parameter NextPrimaryKey when the value of the response parameter HasNext is true in the last query.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
