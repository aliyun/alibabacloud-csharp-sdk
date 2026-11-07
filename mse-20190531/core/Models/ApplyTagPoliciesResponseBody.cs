// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ApplyTagPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ApplyTagPoliciesResponseBodyData> Data { get; set; }
        public class ApplyTagPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether it is a primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CarryData")]
            [Validation(Required=false)]
            public bool? CarryData { get; set; }

            /// <summary>
            /// <para>Indicates whether the feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enabled.</description></item>
            /// <item><description><c>false</c>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

            /// <summary>
            /// <para>Indicates whether the deletion is successful.</para>
            /// </summary>
            [NameInMap("Remove")]
            [Validation(Required=false)]
            public bool? Remove { get; set; }

            /// <summary>
            /// <para>The tag rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;_base\&quot;: {\&quot;rate\&quot;: 100, \&quot;remove\&quot;: true}, \&quot;blue\&quot;: {\&quot;rate\&quot;: 0}}</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public string Rules { get; set; }

            /// <summary>
            /// <para>The effective status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gray</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>316F5F64-F73D-42DC-8632-01E308B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
