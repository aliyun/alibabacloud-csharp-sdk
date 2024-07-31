// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpSensitiveDataRequest : TeaModel {
        /// <summary>
        /// The date on which access records were generated. Specify the value in the yyyyMMdd format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// The parameters that you can configure to query the access records. Valid values:
        /// 
        /// *   dbType
        /// *   instanceName
        /// *   databaseName
        /// *   projectName
        /// *   clusterName
        /// 
        /// The following example shows the parameters configured to query the access records of the sensitive data in the abc database of the Hologres instance ABC: [ {"dbType":"hologres","instanceName":"ABC","databaseName":"abc"} ]
        /// 
        /// You must configure the parameters based on the compute engine that you use in your business.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The operation that is performed on the data. Valid values:
        /// 
        /// *   SQL_SELECT: specifies the data access operation. For example, execute a SELECT statement to query data.
        /// *   TUNNEL_DOWNLOAD: specifies the data download operation. For example, run a Tunnel command to download data.
        /// </summary>
        [NameInMap("OpType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        /// <summary>
        /// The page number. Minimum value: 1. Maximum value: 1000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Minimum value: 1. Maximum value: 1000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
