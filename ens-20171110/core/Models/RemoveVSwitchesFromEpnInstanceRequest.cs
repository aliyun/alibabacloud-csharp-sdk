// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveVSwitchesFromEpnInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of theEPN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// The internal networking information that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitchesInfo")]
        [Validation(Required=false)]
        public string VSwitchesInfo { get; set; }

    }

}
