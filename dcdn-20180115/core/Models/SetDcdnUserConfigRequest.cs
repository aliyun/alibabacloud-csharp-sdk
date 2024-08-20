// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnUserConfigRequest : TeaModel {
        /// <summary>
        /// The configuration parameters of the feature.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string Configs { get; set; }

        /// <summary>
        /// The ID of the feature.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FunctionId")]
        [Validation(Required=false)]
        public int? FunctionId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
