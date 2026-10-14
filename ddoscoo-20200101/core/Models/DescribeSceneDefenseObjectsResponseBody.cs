// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefenseObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the protected assets.</para>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<DescribeSceneDefenseObjectsResponseBodyObjects> Objects { get; set; }
        public class DescribeSceneDefenseObjectsResponseBodyObjects : TeaModel {
            /// <summary>
            /// <para>The domain name that is protected by the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47e07ebd-0ba5-4afc-957b-59d15b90****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance that is protected by the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.XX.XX.119</para>
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE07E73F-F19E-4A51-B62F-AC59E3B962D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
