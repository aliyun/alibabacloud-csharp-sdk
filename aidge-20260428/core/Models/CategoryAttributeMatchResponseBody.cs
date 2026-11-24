// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class CategoryAttributeMatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CategoryAttributeMatchResponseBodyData Data { get; set; }
        public class CategoryAttributeMatchResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of attribute filling results.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<CategoryAttributeMatchResponseBodyDataAttributes> Attributes { get; set; }
            public class CategoryAttributeMatchResponseBodyDataAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>682439</para>
                /// </summary>
                [NameInMap("AttrId")]
                [Validation(Required=false)]
                public int? AttrId { get; set; }

                /// <summary>
                /// <para>The matching confidence level. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public int? Confidence { get; set; }

                /// <summary>
                /// <para>The attribute input type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Single-select dropdown</para>
                /// </summary>
                [NameInMap("InputType")]
                [Validation(Required=false)]
                public string InputType { get; set; }

                /// <summary>
                /// <para>Indicates whether the attribute is matched successfully. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Matched")]
                [Validation(Required=false)]
                public bool? Matched { get; set; }

                /// <summary>
                /// <para>The Chinese name of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>netpila-backup-vpc-j5ekvvg5i5iquaeqbyf6b-cn-shenzhen-finance-1d</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The English name of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ABC Private POP</para>
                /// </summary>
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                /// <summary>
                /// <para>The description of the matching reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a_reason</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The list of selected attribute value texts, such as [&quot;iOS&quot;,&quot;Android&quot;\].</para>
                /// </summary>
                [NameInMap("SelectedValues")]
                [Validation(Required=false)]
                public List<string> SelectedValues { get; set; }

                /// <summary>
                /// <para>The list of selected attribute value IDs, such as [30127,30128\].</para>
                /// 
                /// <b>Example:</b>
                /// <para>[30127,30128]</para>
                /// </summary>
                [NameInMap("SelectedVids")]
                [Validation(Required=false)]
                public List<int?> SelectedVids { get; set; }

            }

            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1516</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cat collar</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The full path of the category, separated by forward slashes (/).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pet Supplies/Cat Supplies/Cat Pendants, Collars, and Leashes/Cat Collar</para>
            /// </summary>
            [NameInMap("CategoryPath")]
            [Validation(Required=false)]
            public string CategoryPath { get; set; }

            /// <summary>
            /// <para>The number of successfully filled attributes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("FilledCount")]
            [Validation(Required=false)]
            public int? FilledCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the attribute is matched successfully. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Matched")]
            [Validation(Required=false)]
            public bool? Matched { get; set; }

            /// <summary>
            /// <para>The total number of attributes under the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalAttributes")]
            [Validation(Required=false)]
            public int? TotalAttributes { get; set; }

            /// <summary>
            /// <para>The usage fields.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public CategoryAttributeMatchResponseBodyDataUsageMap UsageMap { get; set; }
            public class CategoryAttributeMatchResponseBodyDataUsageMap : TeaModel {
                /// <summary>
                /// <para>The processing count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProcessingCount")]
                [Validation(Required=false)]
                public int? ProcessingCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9927B72F-3C8F-54C0-AAE3-2B1AC94BB6EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
