// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acm20200206.Models
{
    public class CheckConfigurationCloneRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceFrom")]
        [Validation(Required=false)]
        public string NamespaceFrom { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceTo")]
        [Validation(Required=false)]
        public string NamespaceTo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

    }

}
