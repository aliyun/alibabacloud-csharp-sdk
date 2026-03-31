// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceInventoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89E2F38F-4EE4-545A-BD56-92E007ECFEE9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource inventory.</para>
        /// </summary>
        [NameInMap("ResourceInventory")]
        [Validation(Required=false)]
        public GetResourceInventoryResponseBodyResourceInventory ResourceInventory { get; set; }
        public class GetResourceInventoryResponseBodyResourceInventory : TeaModel {
            /// <summary>
            /// <para>The download URL of the resource inventory.</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the resource inventory was generated. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687674634220</para>
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
