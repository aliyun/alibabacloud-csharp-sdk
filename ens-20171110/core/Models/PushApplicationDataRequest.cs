// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The data files that you want to push. The value must be a JSON string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The push policy in the canary release environment. The value must be a JSON string. You can specify multiple push policies. By default, all data files are pushed.
        /// </summary>
        [NameInMap("PushStrategy")]
        [Validation(Required=false)]
        public string PushStrategy { get; set; }

        /// <summary>
        /// This parameter does not take effect.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
