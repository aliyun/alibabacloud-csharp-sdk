// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The available ASM versions.</para>
        /// </summary>
        [NameInMap("VersionInfo")]
        [Validation(Required=false)]
        public List<DescribeVersionsResponseBodyVersionInfo> VersionInfo { get; set; }
        public class DescribeVersionsResponseBodyVersionInfo : TeaModel {
            /// <summary>
            /// <para>The edition of the ASM instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Default</c>: Standard Edition</description></item>
            /// <item><description><c>Pro</c>: Professional Edition that is commercially released</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The list of ASM versions available for the ASM instance of the current edition.</para>
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

    }

}
