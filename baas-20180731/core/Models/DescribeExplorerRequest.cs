// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeExplorerRequest : TeaModel {
        [NameInMap("ExBody")]
        [Validation(Required=false)]
        public string ExBody { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExMethod")]
        [Validation(Required=false)]
        public string ExMethod { get; set; }

        [NameInMap("ExUrl")]
        [Validation(Required=false)]
        public string ExUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
