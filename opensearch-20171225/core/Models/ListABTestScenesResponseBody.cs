// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListABTestScenesResponseBody : TeaModel {
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
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/173618.html">ABTestScene</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListABTestScenesResponseBodyResult> Result { get; set; }
        public class ListABTestScenesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the test group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588836130</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20404</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The alias of the test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kevintest_2020-5-7_15:21:482</para>
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
            /// <para>1588836129</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// <para>The name of the test scenario.</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

    }

}
