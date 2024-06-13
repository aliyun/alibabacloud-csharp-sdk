// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteBackendModelRequest : TeaModel {
        /// <summary>
        /// The ID of the backend service.
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// The ID of the backend model.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendModelId")]
        [Validation(Required=false)]
        public string BackendModelId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The environment to which the API is published. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **PRE**
        /// *   **TEST**
        /// 
        /// If you do not specify this parameter, APIs in the draft state are returned.
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
