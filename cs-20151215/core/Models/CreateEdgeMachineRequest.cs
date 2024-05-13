// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateEdgeMachineRequest : TeaModel {
        /// <summary>
        /// The `hostname` of the cloud-native box.
        /// 
        /// >  After the cloud-native box is activated, the `hostname` is automatically modified. The `hostname` is prefixed with the model and the prefix is followed by a random string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// The model of the cloud-native box.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// The serial number of the cloud-native box.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
