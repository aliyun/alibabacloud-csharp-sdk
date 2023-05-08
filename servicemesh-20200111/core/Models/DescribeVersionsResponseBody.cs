// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVersionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The available ASM versions.
        /// </summary>
        [NameInMap("VersionInfo")]
        [Validation(Required=false)]
        public List<DescribeVersionsResponseBodyVersionInfo> VersionInfo { get; set; }
        public class DescribeVersionsResponseBodyVersionInfo : TeaModel {
            /// <summary>
            /// The edition of the ASM instance. Valid values:
            /// 
            /// *   `Default`: Standard Edition
            /// *   `Pro`: Professional Edition that is commercially released
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// The ASM versions available for the ASM instance of the current edition.
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

    }

}
