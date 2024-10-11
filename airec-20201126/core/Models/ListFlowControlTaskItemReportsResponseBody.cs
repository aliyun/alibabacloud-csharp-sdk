// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskItemReportsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D486768B-8BF8-4D80-B491-43DC3D0AF8AB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFlowControlTaskItemReportsResponseBodyResult Result { get; set; }
        public class ListFlowControlTaskItemReportsResponseBodyResult : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<ListFlowControlTaskItemReportsResponseBodyResultDetail> Detail { get; set; }
            public class ListFlowControlTaskItemReportsResponseBodyResultDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3.24</para>
                /// </summary>
                [NameInMap("accClickPercent")]
                [Validation(Required=false)]
                public string AccClickPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("accItemClick")]
                [Validation(Required=false)]
                public string AccItemClick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4.56</para>
                /// </summary>
                [NameInMap("accItemCtr")]
                [Validation(Required=false)]
                public string AccItemCtr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("accItemPv")]
                [Validation(Required=false)]
                public string AccItemPv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20.12</para>
                /// </summary>
                [NameInMap("accPvPercent")]
                [Validation(Required=false)]
                public string AccPvPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("accTaskClick")]
                [Validation(Required=false)]
                public string AccTaskClick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.22</para>
                /// </summary>
                [NameInMap("accTaskCtr")]
                [Validation(Required=false)]
                public string AccTaskCtr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("accTaskPv")]
                [Validation(Required=false)]
                public string AccTaskPv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("accTaskRank")]
                [Validation(Required=false)]
                public string AccTaskRank { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.23</para>
                /// </summary>
                [NameInMap("clickPercent")]
                [Validation(Required=false)]
                public string ClickPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("itemClick")]
                [Validation(Required=false)]
                public string ItemClick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.34</para>
                /// </summary>
                [NameInMap("itemCtr")]
                [Validation(Required=false)]
                public string ItemCtr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("itemPv")]
                [Validation(Required=false)]
                public string ItemPv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.12</para>
                /// </summary>
                [NameInMap("pvPercent")]
                [Validation(Required=false)]
                public string PvPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("taskClick")]
                [Validation(Required=false)]
                public string TaskClick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.23</para>
                /// </summary>
                [NameInMap("taskCtr")]
                [Validation(Required=false)]
                public string TaskCtr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1666669577221</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("taskPv")]
                [Validation(Required=false)]
                public string TaskPv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("taskRank")]
                [Validation(Required=false)]
                public string TaskRank { get; set; }

            }

        }

    }

}
