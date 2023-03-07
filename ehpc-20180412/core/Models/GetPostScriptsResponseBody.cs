// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetPostScriptsResponseBody : TeaModel {
        /// <summary>
        /// The post-installation scripts.
        /// </summary>
        [NameInMap("PostInstallScripts")]
        [Validation(Required=false)]
        public List<GetPostScriptsResponseBodyPostInstallScripts> PostInstallScripts { get; set; }
        public class GetPostScriptsResponseBodyPostInstallScripts : TeaModel {
            /// <summary>
            /// The parameter that is used to run the Nth post-installation script. Valid values of N: 1 to 16.
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// The URL that is used to download the Nth post-installation script. Valid values of N: 1 to 16.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
