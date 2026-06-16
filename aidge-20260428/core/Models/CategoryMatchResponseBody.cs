// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class CategoryMatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The value &quot;success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The product category matching result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CategoryMatchResponseBodyData Data { get; set; }
        public class CategoryMatchResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the matched category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1522</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The name of the matched category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>位置和活动跟踪器</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The full path of the category, separated by forward slashes (/).</para>
            /// 
            /// <b>Example:</b>
            /// <para>宠物用品/猫用品/猫挂饰、项圈、牵引带/位置和活动跟踪器</para>
            /// </summary>
            [NameInMap("CategoryPath")]
            [Validation(Required=false)]
            public string CategoryPath { get; set; }

            /// <summary>
            /// <para>The matching confidence score, ranging from 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96</para>
            /// </summary>
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public int? Confidence { get; set; }

            /// <summary>
            /// <para>Indicates whether the match is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MatchSuccessful")]
            [Validation(Required=false)]
            public bool? MatchSuccessful { get; set; }

            /// <summary>
            /// <para>The reason for the match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>商品核心为带 AirTag 定位功能的猫项圈，属\&quot;位置和活动跟踪器\&quot;类目，叶子节点语义精准匹配其追踪功能与猫用属性。</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The usage information.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. The value &quot;Success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2157065A-D6C8-1F3E-A4D0-B1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
