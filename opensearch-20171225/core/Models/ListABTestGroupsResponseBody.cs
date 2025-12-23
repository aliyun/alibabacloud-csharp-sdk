// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListABTestGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D77D0DAF-790D-F5F5-A9C0-133738165014</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The test groups.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/178935.html">ABTestGroup</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListABTestGroupsResponseBodyResult> Result { get; set; }
        public class ListABTestGroupsResponseBodyResult : TeaModel {
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
            /// <para>The name of the test group.</para>
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
            /// <para>The time when the test group was last modified.</para>
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
