// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebAclEntryConfig : TeaModel {
        /// <summary>
        /// <para>The IP address.</para>
        /// <remarks>
        /// <para> CIDR notation is not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219.145.XX.XX</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public string Entry { get; set; }

    }

}
