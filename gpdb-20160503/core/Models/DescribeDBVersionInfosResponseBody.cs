// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBVersionInfosResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried minor versions.
        /// </summary>
        [NameInMap("VersionDetails")]
        [Validation(Required=false)]
        public DescribeDBVersionInfosResponseBodyVersionDetails VersionDetails { get; set; }
        public class DescribeDBVersionInfosResponseBodyVersionDetails : TeaModel {
            /// <summary>
            /// The queried minor version information about the instance in Serverless mode.
            /// </summary>
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public object Serverless { get; set; }

            /// <summary>
            /// The queried minor version information about the instance in elastic storage mode.
            /// </summary>
            [NameInMap("StorageElastic")]
            [Validation(Required=false)]
            public object StorageElastic { get; set; }

        }

    }

}
