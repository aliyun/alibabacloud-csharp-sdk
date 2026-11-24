// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class CategoryMatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Returns &quot;success&quot; for normal calls.</para>
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
            /// <para>The matched category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1522</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The matched category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Location and Activity Trackers</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The full path of the category, separated by forward slashes (/).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pet Supplies/Cat Supplies/Cat Collars, Harnesses and Leashes/Location and Activity Trackers</para>
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
            /// <para>Indicates whether the matching is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MatchSuccessful")]
            [Validation(Required=false)]
            public bool? MatchSuccessful { get; set; }

            /// <summary>
            /// <para>The matching reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The core of the product is a cat collar with AirTag tracking functionality, which belongs to the \&quot;Location and Activity Trackers\&quot; category. The leaf node semantics precisely match its tracking function and cat-specific attributes</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. Returns &quot;Success&quot; for normal calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which identifies a unique request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2157065A-D6C8-1F3E-A4D0-B1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
