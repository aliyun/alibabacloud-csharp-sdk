// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeGreyTagRouteRequest : TeaModel {
        /// <summary>
        /// The ID of the canary release rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GreyTagRouteId")]
        [Validation(Required=false)]
        public long? GreyTagRouteId { get; set; }

    }

}
