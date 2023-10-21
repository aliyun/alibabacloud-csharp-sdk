// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDbProxyInstanceSslRequest : TeaModel {
        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~610399~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
