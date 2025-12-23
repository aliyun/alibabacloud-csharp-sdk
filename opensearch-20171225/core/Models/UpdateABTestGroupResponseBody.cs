// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateABTestGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;\&quot;1111\&quot;\&quot;</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the test group.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateABTestGroupResponseBodyResult Result { get; set; }
        public class UpdateABTestGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the test group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588839490</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13466</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The alias of the test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group_2020-5-7_15:23:3</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the test group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: not in effect</description></item>
            /// <item><description>1: in effect</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the test group was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588839490</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
