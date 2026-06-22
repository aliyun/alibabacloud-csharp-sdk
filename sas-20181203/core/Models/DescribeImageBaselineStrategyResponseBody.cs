// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F85AC10-A1FE-54D7-935A-F28D5256****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The baseline check policy information.</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeImageBaselineStrategyResponseBodyStrategy Strategy { get; set; }
        public class DescribeImageBaselineStrategyResponseBodyStrategy : TeaModel {
            /// <summary>
            /// <para>The agentless baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc_win2008_cis_rules</para>
            /// </summary>
            [NameInMap("BaselineItem")]
            [Validation(Required=false)]
            public string BaselineItem { get; set; }

            /// <summary>
            /// <para>The list of baseline items.</para>
            /// </summary>
            [NameInMap("BaselineItemList")]
            [Validation(Required=false)]
            public List<DescribeImageBaselineStrategyResponseBodyStrategyBaselineItemList> BaselineItemList { get; set; }
            public class DescribeImageBaselineStrategyResponseBodyStrategyBaselineItemList : TeaModel {
                /// <summary>
                /// <para>The classification key of the baseline main item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>identification</para>
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// <para>The key of the baseline subitem.</para>
                /// 
                /// <b>Example:</b>
                /// <para>duplicate_pwd_hash</para>
                /// </summary>
                [NameInMap("ItemKey")]
                [Validation(Required=false)]
                public string ItemKey { get; set; }

                /// <summary>
                /// <para>The name key of the baseline main item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>identification</para>
                /// </summary>
                [NameInMap("NameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

            }

            /// <summary>
            /// <para>The retention period of baseline risks. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ImageVulClean")]
            [Validation(Required=false)]
            public int? ImageVulClean { get; set; }

            /// <summary>
            /// <para>The number of selected baseline check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SelectedItemCount")]
            [Validation(Required=false)]
            public int? SelectedItemCount { get; set; }

            /// <summary>
            /// <para>The ID of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8257</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// <para>The Policy Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The total number of baseline check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            /// <summary>
            /// <para>The type of the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: default policy</description></item>
            /// <item><description><b>full</b>: full baseline item policy</description></item>
            /// <item><description><b>normal</b>: common baseline item policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
