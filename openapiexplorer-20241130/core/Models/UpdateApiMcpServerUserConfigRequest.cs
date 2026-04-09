// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class UpdateApiMcpServerUserConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublicAccess")]
        [Validation(Required=false)]
        public bool? EnablePublicAccess { get; set; }

        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

    }

}
