// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyBackendRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
