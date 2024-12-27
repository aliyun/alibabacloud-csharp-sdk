// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListIpOrHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP addresses.</para>
        /// </summary>
        [NameInMap("IpNames")]
        [Validation(Required=false)]
        public ListIpOrHostsResponseBodyIpNames IpNames { get; set; }
        public class ListIpOrHostsResponseBodyIpNames : TeaModel {
            [NameInMap("IpName")]
            [Validation(Required=false)]
            public List<string> IpName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1FC4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
