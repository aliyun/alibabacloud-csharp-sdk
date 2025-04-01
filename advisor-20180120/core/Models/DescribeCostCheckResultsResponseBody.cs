// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeCostCheckResultsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCostCheckResultsResponseBodyData Data { get; set; }
        public class DescribeCostCheckResultsResponseBodyData : TeaModel {
            [NameInMap("AdviceResourceCount")]
            [Validation(Required=false)]
            public int? AdviceResourceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Category</para>
            /// </summary>
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public string GroupBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NormalCount")]
            [Validation(Required=false)]
            public int? NormalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public int? ResourceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("ViewGroup")]
            [Validation(Required=false)]
            public List<DescribeCostCheckResultsResponseBodyDataViewGroup> ViewGroup { get; set; }
            public class DescribeCostCheckResultsResponseBodyDataViewGroup : TeaModel {
                [NameInMap("CheckItems")]
                [Validation(Required=false)]
                public List<DescribeCostCheckResultsResponseBodyDataViewGroupCheckItems> CheckItems { get; set; }
                public class DescribeCostCheckResultsResponseBodyDataViewGroupCheckItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AdviceCount")]
                    [Validation(Required=false)]
                    public int? AdviceCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AdviceResourceCount")]
                    [Validation(Required=false)]
                    public int? AdviceResourceCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EbsCostIdleCheck</para>
                    /// </summary>
                    [NameInMap("CheckId")]
                    [Validation(Required=false)]
                    public string CheckId { get; set; }

                    [NameInMap("CheckName")]
                    [Validation(Required=false)]
                    public string CheckName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentCost")]
                    [Validation(Required=false)]
                    public float? CurrentCost { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ExpectedSavingCost")]
                    [Validation(Required=false)]
                    public float? ExpectedSavingCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OptimizedCost")]
                    [Validation(Required=false)]
                    public float? OptimizedCost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>slb</para>
                    /// </summary>
                    [NameInMap("Product")]
                    [Validation(Required=false)]
                    public string Product { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public int? Severity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public string Tips { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public int? GroupCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GroupExpectedSavingCost")]
                [Validation(Required=false)]
                public float? GroupExpectedSavingCost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aut***8ainRh1</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WarningCount")]
            [Validation(Required=false)]
            public int? WarningCount { get; set; }

        }

        /// <summary>
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
        /// <para>566331F9-****-550F-B745-A730331F97A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
