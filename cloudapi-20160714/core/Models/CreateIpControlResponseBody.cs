// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateIpControlResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ea91319a34d48a09b5c9c871d9768b1</para>
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE5722A6-AE78-4741-A9B0-6C817D360510</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
