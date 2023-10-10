// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteEdgeMachineRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcefully delete the cloud-native box. Valid values:
        /// 
        /// *   `true`: forcefully deletes the cloud-native box.
        /// *   `false`: does not forcefully delete the cloud-native box.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public string Force { get; set; }

    }

}
