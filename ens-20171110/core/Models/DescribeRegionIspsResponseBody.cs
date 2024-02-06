// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeRegionIspsResponseBody : TeaModel {
        /// <summary>
        /// The list of ISPs.
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribeRegionIspsResponseBodyIsps> Isps { get; set; }
        public class DescribeRegionIspsResponseBodyIsps : TeaModel {
            /// <summary>
            /// The code of the ISP.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The name of the ISP.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
