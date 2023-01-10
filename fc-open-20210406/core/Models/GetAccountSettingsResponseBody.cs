// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetAccountSettingsResponseBody : TeaModel {
        /// <summary>
        /// The list of zones.
        /// </summary>
        [NameInMap("availableAZs")]
        [Validation(Required=false)]
        public List<string> AvailableAZs { get; set; }

        /// <summary>
        /// The default RAM role.
        /// </summary>
        [NameInMap("defaultRole")]
        [Validation(Required=false)]
        public string DefaultRole { get; set; }

    }

}
