// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeCharsetRequest : TeaModel {
        /// <summary>
        /// The tenant mode.    
        /// Valid values: Oracle and MySQL.   
        /// For more information, see [DescribeInstanceTenantModes](~~410354~~).
        /// </summary>
        [NameInMap("TenantMode")]
        [Validation(Required=false)]
        public string TenantMode { get; set; }

    }

}
