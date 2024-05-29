// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The data structure.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// The ID of the destination namespace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The policy used when a write conflict occurs.
        /// 
        /// *   ABORT
        /// *   SKIP
        /// *   OVERWRITE
        /// </summary>
        [NameInMap("OriginNamespaceId")]
        [Validation(Required=false)]
        public string OriginNamespaceId { get; set; }

        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The IDs of configurations.
        /// </summary>
        [NameInMap("TargetNamespaceId")]
        [Validation(Required=false)]
        public string TargetNamespaceId { get; set; }

    }

}
