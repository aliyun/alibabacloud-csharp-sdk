// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The resource nodes.</para>
        /// </summary>
        [NameInMap("NodeModels")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyNodeModels> NodeModels { get; set; }
        public class ListNodesResponseBodyNodeModels : TeaModel {
            /// <summary>
            /// <para>The billing method of the resource node.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the ChargeResourceMode parameter of the delivery group to which the resource node belongs is set to Node.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PostPaid: pay-as-you-go</description></item>
            /// <item><description>Prepaid: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The ID of the resource node.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the ChargeResourceMode parameter of the delivery group to which the resource node belongs is set to Node.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13********</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PerPageSize")]
        [Validation(Required=false)]
        public int? PerPageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ToPage")]
        [Validation(Required=false)]
        public int? ToPage { get; set; }

    }

}
