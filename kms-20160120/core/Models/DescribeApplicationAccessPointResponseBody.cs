// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeApplicationAccessPointResponseBody : TeaModel {
        /// <summary>
        /// The ARN of the AAP.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The authentication method.
        /// </summary>
        [NameInMap("AuthenticationMethod")]
        [Validation(Required=false)]
        public string AuthenticationMethod { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the AAP.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The permission policy that is bound to the AAP.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
