// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class DescribeEdgeStatInfoRequest : TeaModel {
        [NameInMap("EdgeDn")]
        [Validation(Required=false)]
        public string EdgeDn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EdgePk")]
        [Validation(Required=false)]
        public string EdgePk { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
