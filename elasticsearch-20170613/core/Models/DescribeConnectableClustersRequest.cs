// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeConnectableClustersRequest : TeaModel {
        /// <summary>
        /// The ID of the instance that can communicate with each other.
        /// </summary>
        [NameInMap("alreadySetItems")]
        [Validation(Required=false)]
        public bool? AlreadySetItems { get; set; }

    }

}
