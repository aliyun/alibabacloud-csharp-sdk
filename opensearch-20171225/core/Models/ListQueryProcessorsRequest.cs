// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQueryProcessorsRequest : TeaModel {
        /// <summary>
        /// The scope of query analysis rules to be queried. Default value: 0. Valid values:
        /// 
        /// *   0: queries all query analysis rules.
        /// *   1: queries the default query analysis rules.
        /// *   2: queries the query analysis rules that are not the default rules.
        /// </summary>
        [NameInMap("isActive")]
        [Validation(Required=false)]
        public int? IsActive { get; set; }

    }

}
