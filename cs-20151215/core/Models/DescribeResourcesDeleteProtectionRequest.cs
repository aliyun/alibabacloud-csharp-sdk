// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeResourcesDeleteProtectionRequest : TeaModel {
        /// <summary>
        /// The namespace to which the resource belongs.
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the resource that you want to query. Separate multiple resource names with commas (,).
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
