// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModifyParameterLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried parameter modification logs.</para>
        /// </summary>
        [NameInMap("Changelogs")]
        [Validation(Required=false)]
        public List<DescribeModifyParameterLogResponseBodyChangelogs> Changelogs { get; set; }
        public class DescribeModifyParameterLogResponseBodyChangelogs : TeaModel {
            /// <summary>
            /// <para>The effective time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-03T17:00:00Z</para>
            /// </summary>
            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>Indicates whether the modification takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ParameterValid")]
            [Validation(Required=false)]
            public string ParameterValid { get; set; }

            /// <summary>
            /// <para>The original value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ParameterValueAfter")]
            [Validation(Required=false)]
            public string ParameterValueAfter { get; set; }

            /// <summary>
            /// <para>The new value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ParameterValueBefore")]
            [Validation(Required=false)]
            public string ParameterValueBefore { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FA1F1D1-50A6-4F60-9A78-5752F2076A53</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
