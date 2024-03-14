// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSignatureLibVersionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the versions.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public List<DescribeSignatureLibVersionResponseBodyVersion> Version { get; set; }
        public class DescribeSignatureLibVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// The type.
            /// 
            /// Valid values:
            /// 
            /// *   ips
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Basic Rules and Virtual Patching
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   intelligence
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Threat Intelligence
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
