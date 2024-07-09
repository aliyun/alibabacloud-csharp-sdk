// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeResourcesDeleteProtectionResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeResourcesDeleteProtectionResponseBody> Body { get; set; }
        public class DescribeResourcesDeleteProtectionResponseBody : TeaModel {
            /// <summary>
            /// The name of the resource.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace to which the resource belongs.
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The type of resource for which deletion protection is enabled.
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// Indicates whether deletion protection is enabled.
            /// 
            /// *   true: deletion protection is enabled.
            /// *   false: deletion protection is disabled.
            /// 
            /// Default value: false
            /// </summary>
            [NameInMap("protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

        }

    }

}
