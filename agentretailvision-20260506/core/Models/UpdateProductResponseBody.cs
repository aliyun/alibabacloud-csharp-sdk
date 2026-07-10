// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class UpdateProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The item information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateProductResponseBodyData Data { get; set; }
        public class UpdateProductResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business-side item ID, which is unique within the same business party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ITEM_001</para>
            /// </summary>
            [NameInMap("ItemUniqueId")]
            [Validation(Required=false)]
            public string ItemUniqueId { get; set; }

            /// <summary>
            /// <para>The platform item ID, which is globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PLAT_001</para>
            /// </summary>
            [NameInMap("PlatformItemId")]
            [Validation(Required=false)]
            public string PlatformItemId { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
