// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainSecurityProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeDomainSecurityProfileResponseBodyResult> Result { get; set; }
        public class DescribeDomainSecurityProfileResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the global mitigation policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalEnable")]
            [Validation(Required=false)]
            public bool? GlobalEnable { get; set; }

            /// <summary>
            /// <para>The mode of the global mitigation policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>weak</b>: the Low mode</description></item>
            /// <item><description><b>default</b>: the Normal mode</description></item>
            /// <item><description><b>hard</b>: the Strict mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GlobalMode")]
            [Validation(Required=false)]
            public string GlobalMode { get; set; }

        }

    }

}
