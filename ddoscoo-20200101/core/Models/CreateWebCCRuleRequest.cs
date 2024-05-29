// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateWebCCRuleRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Act")]
        [Validation(Required=false)]
        public string Act { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
