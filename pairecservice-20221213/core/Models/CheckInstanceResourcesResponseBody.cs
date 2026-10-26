// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CheckInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9763624B-5FBB-5E3A-9193-B1ADB554CEAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CheckInstanceResourcesResponseBodyResources> Resources { get; set; }
        public class CheckInstanceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success</description></item>
            /// <item><description>Failure</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Hologres</description></item>
            /// <item><description>EAS</description></item>
            /// <item><description>BE</description></item>
            /// <item><description>Rec</description></item>
            /// <item><description>Platform</description></item>
            /// <item><description>SLS</description></item>
            /// <item><description>DataHub</description></item>
            /// <item><description>Kafka</description></item>
            /// <item><description>Flinkvvp</description></item>
            /// <item><description>ACR</description></item>
            /// <item><description>OSS</description></item>
            /// <item><description>DataWorks</description></item>
            /// <item><description>PAI</description></item>
            /// <item><description>MaxCompute</description></item>
            /// <item><description>GraphCompute</description></item>
            /// <item><description>Redis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The resource URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucket-test-123</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

    }

}
