// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsRdsInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the PolarDB-X instance.
        /// 
        /// > You can call the [DescribeDrdsInstances](~~139284~~) operation to query the information about instances in the specified account, such as the IDs of the instances.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

    }

}
