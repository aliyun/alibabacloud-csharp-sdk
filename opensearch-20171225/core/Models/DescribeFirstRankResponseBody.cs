// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeFirstRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the rough sort expression.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeFirstRankResponseBodyResult Result { get; set; }
        public class DescribeFirstRankResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the expression is the default one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The information about the expression.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<DescribeFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class DescribeFirstRankResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The parameters that are used by a function in the expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ar_edit_time</para>
                /// </summary>
                [NameInMap("arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                /// <summary>
                /// <para>The attribute, feature function, or field to be searched for.</para>
                /// 
                /// <b>Example:</b>
                /// <para>timeliness_ms()</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The weight. Valid values: -100000 to 100000. The value cannot be 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            /// <summary>
            /// <para>Parameter</para>
            /// 
            /// <b>Example:</b>
            /// <para>ar_wear_edit_time</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
