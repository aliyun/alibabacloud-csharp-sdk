// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarAgentSessionStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the session. This ID is used to identify a visitor\&quot;s session and maintain context information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e28530a0da2c4755f165b1b8b9a73c9</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The source of the product. Set the value to polardb-console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb-console</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
