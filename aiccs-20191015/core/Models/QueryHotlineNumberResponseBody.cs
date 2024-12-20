// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryHotlineNumberResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryHotlineNumberResponseBodyData Data { get; set; }
        public class QueryHotlineNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("HotlineNumList")]
            [Validation(Required=false)]
            public List<QueryHotlineNumberResponseBodyDataHotlineNumList> HotlineNumList { get; set; }
            public class QueryHotlineNumberResponseBodyDataHotlineNumList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CalloutAllDepartment")]
                [Validation(Required=false)]
                public bool? CalloutAllDepartment { get; set; }

                [NameInMap("CalloutRangeList")]
                [Validation(Required=false)]
                public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList> CalloutRangeList { get; set; }
                public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2256****</para>
                    /// </summary>
                    [NameInMap("DepartmentId")]
                    [Validation(Required=false)]
                    public long? DepartmentId { get; set; }

                    [NameInMap("DepartmentName")]
                    [Validation(Required=false)]
                    public string DepartmentName { get; set; }

                    [NameInMap("GroupDOList")]
                    [Validation(Required=false)]
                    public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList> GroupDOList { get; set; }
                    public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>6083****</para>
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EvaluationStatus")]
                [Validation(Required=false)]
                public int? EvaluationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public long? FlowId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试流程</para>
                /// </summary>
                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0571****2211</para>
                /// </summary>
                [NameInMap("HotlineNumber")]
                [Validation(Required=false)]
                public string HotlineNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("InBoundEnabled")]
                [Validation(Required=false)]
                public bool? InBoundEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>浙江杭州</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OutboundEnabled")]
                [Validation(Required=false)]
                public bool? OutboundEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>电信</para>
                /// </summary>
                [NameInMap("Sp")]
                [Validation(Required=false)]
                public string Sp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
