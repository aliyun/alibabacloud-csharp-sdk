// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class StartDesktopsRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The OS used by the client.
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// StartDesktops
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The ID of cloud desktop N. You can specify one or more IDs of cloud desktops. Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// The logon credential.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to StartDesktops.
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
