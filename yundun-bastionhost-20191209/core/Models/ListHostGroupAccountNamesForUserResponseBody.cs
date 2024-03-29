// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupAccountNamesForUserResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the names of host accounts.
        /// </summary>
        [NameInMap("HostAccountNames")]
        [Validation(Required=false)]
        public List<string> HostAccountNames { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
