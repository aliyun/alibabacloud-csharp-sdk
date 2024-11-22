// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeHttpDDoSAttackProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The level of HTTP DDoS attack protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>very weak</b>: very loose.</description></item>
        /// <item><description><b>weak</b>: loose.</description></item>
        /// <item><description><b>default</b>: normal.</description></item>
        /// <item><description><b>hard</b>: strict.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("GlobalMode")]
        [Validation(Required=false)]
        public string GlobalMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35C66C7B-671H-4297-9187-2C4477247A78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
