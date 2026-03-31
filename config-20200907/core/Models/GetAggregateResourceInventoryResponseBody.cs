// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceInventoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A6D3604-EF1A-5798-A576-2A5FB855493C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource inventory.</para>
        /// </summary>
        [NameInMap("ResourceInventory")]
        [Validation(Required=false)]
        public GetAggregateResourceInventoryResponseBodyResourceInventory ResourceInventory { get; set; }
        public class GetAggregateResourceInventoryResponseBodyResourceInventory : TeaModel {
            /// <summary>
            /// <para>The download URL of the resource inventory.</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the resource inventory was generated. The value is a timestamp.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687674774123</para>
            /// </summary>
            [NameInMap("ResourceInventoryGenerateTime")]
            [Validation(Required=false)]
            public long? ResourceInventoryGenerateTime { get; set; }

            /// <summary>
            /// <para>The generation status of the resource inventory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: The resource inventory is being generated.</description></item>
            /// <item><description>COMPLETE: The resource inventory is generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
