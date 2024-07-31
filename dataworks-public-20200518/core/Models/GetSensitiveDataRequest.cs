// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSensitiveDataRequest : TeaModel {
        /// <summary>
        /// The parameters that you can configure to query the access records. Valid values:
        /// 
        /// *   dbType
        /// *   instanceName
        /// *   databaseName
        /// *   projectName
        /// *   clusterName
        /// 
        /// The sample value shows the parameters configured to query the access records of the sensitive data in the abc database of the Hologres instance ABC. You must configure the parameters based on the compute engine that you use in your business.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 1000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
