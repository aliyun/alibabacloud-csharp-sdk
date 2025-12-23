// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateABTestSceneResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D77D0DAF-790D-F5F5-A9C0-133738165014</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateABTestSceneResponseBodyResult Result { get; set; }
        public class CreateABTestSceneResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the test scenario was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20405</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the A/B test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kevintest_2020-5-7_15:21:48</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
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
            /// <para>The time when the test scenario was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589012351</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// <para>The ID of the test scenario</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

    }

}
