// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeABTestSceneResponseBody : TeaModel {
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
        /// <para>The details of the test scenario.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeABTestSceneResponseBodyResult Result { get; set; }
        public class DescribeABTestSceneResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the test scenario was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596527691</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the test scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20614</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the test scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the test scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The test is stopped.</description></item>
            /// <item><description>1: The test is started.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the test was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596527691</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// <para>The indicators of the test scenarios.</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

    }

}
