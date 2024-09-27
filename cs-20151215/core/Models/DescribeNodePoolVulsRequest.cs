// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeNodePoolVulsRequest : TeaModel {
        /// <summary>
        /// <para>The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>asap</c>: high</description></item>
        /// <item><description><c>later</c>: medium</description></item>
        /// <item><description><c>nntf</c>: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap</para>
        /// </summary>
        [NameInMap("necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

    }

}
