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
        /// <para>A list of resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CheckInstanceResourcesResponseBodyResources> Resources { get; set; }
        public class CheckInstanceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The access status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Success</para>
            /// </description></item>
            /// <item><description><para>Failure</para>
            /// </description></item>
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
            /// <item><description><para>Hologres</para>
            /// </description></item>
            /// <item><description><para>EAS</para>
            /// </description></item>
            /// <item><description><para>BE</para>
            /// </description></item>
            /// <item><description><para>Rec</para>
            /// </description></item>
            /// <item><description><para>Platform</para>
            /// </description></item>
            /// <item><description><para>SLS</para>
            /// </description></item>
            /// <item><description><para>DataHub</para>
            /// </description></item>
            /// <item><description><para>Kafka</para>
            /// </description></item>
            /// <item><description><para>Flinkvvp</para>
            /// </description></item>
            /// <item><description><para>ACR</para>
            /// </description></item>
            /// <item><description><para>OSS</para>
            /// </description></item>
            /// <item><description><para>DataWorks</para>
            /// </description></item>
            /// <item><description><para>PAI</para>
            /// </description></item>
            /// <item><description><para>MaxCompute</para>
            /// </description></item>
            /// <item><description><para>GraphCompute</para>
            /// </description></item>
            /// <item><description><para>Redis</para>
            /// </description></item>
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
