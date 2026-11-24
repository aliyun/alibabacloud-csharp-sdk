// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class AccessControlEntry : TeaModel {
        /// <summary>
        /// <para>The description of the whitelist entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The IP address or CIDR block that is allowed to access the public endpoint of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.1/32</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public string Entry { get; set; }

    }

}
