// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateABTestSceneResponseBody : TeaModel {
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
        /// <para>The details of the test scenario. For more information, see <a href="https://help.aliyun.com/document_detail/173618.html">ABTestScene</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateABTestSceneResponseBodyResult Result { get; set; }
        public class UpdateABTestSceneResponseBodyResult : TeaModel {
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
            /// <para>kevintest22</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the test. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The test is started.</description></item>
            /// <item><description>false: The test is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The parameters of the A/B test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public Dictionary<string, object> Params { get; set; }

            /// <summary>
            /// <para>The percentage of traffic that is allocated to the A/B test. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("traffic")]
            [Validation(Required=false)]
            public int? Traffic { get; set; }

            /// <summary>
            /// <para>The time when the test scenario was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596527691</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
