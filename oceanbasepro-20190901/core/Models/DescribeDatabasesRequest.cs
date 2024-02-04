// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDatabasesRequest : TeaModel {
        /// <summary>
        /// The name of the database.    
        /// You cannot use reserved keywords, such as test and mysql.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of the page returned.  
        /// - Start value: 1   
        /// - Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of rows returned on each page.  
        /// - Maximum value: 100.  
        /// - Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The search keyword.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Specifies whether to return the information of tables in the database.   
        /// Default value: false.
        /// </summary>
        [NameInMap("WithTables")]
        [Validation(Required=false)]
        public bool? WithTables { get; set; }

    }

}
