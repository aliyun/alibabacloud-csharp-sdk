// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteNetworkInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

    }

}
