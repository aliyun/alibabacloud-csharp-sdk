// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportNacosConfigRequest : TeaModel {
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
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The policy.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The policy.
        /// 
        /// Valid values:
        /// 
        /// *   ABORT
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   OVERWRITE
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   SKIP
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

    }

}
