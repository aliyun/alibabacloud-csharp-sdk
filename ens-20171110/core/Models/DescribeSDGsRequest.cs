// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGsRequest : TeaModel {
        /// <summary>
        /// The IDs of instances that you want to query. By default, all instances are queried.
        /// 
        /// >  If you specify the **SDGIds** and **InstanceIds** parameters at the same time, the query result is the intersection of the two conditions.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The IDs of SDGs that you want to query. By default, all SDGs are queried.
        /// </summary>
        [NameInMap("SDGIds")]
        [Validation(Required=false)]
        public List<string> SDGIds { get; set; }

    }

}
