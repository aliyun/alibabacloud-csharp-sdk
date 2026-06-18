// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryHotlineNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of Success indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Hotline number configuration information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryHotlineNumberResponseBodyData Data { get; set; }
        public class QueryHotlineNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number list.</para>
            /// </summary>
            [NameInMap("HotlineNumList")]
            [Validation(Required=false)]
            public List<QueryHotlineNumberResponseBodyDataHotlineNumList> HotlineNumList { get; set; }
            public class QueryHotlineNumberResponseBodyDataHotlineNumList : TeaModel {
                /// <summary>
                /// <para>Outbound calls apply to all departments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CalloutAllDepartment")]
                [Validation(Required=false)]
                public bool? CalloutAllDepartment { get; set; }

                /// <summary>
                /// <para>List of departments for which outbound calls are effective.</para>
                /// </summary>
                [NameInMap("CalloutRangeList")]
                [Validation(Required=false)]
                public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList> CalloutRangeList { get; set; }
                public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList : TeaModel {
                    /// <summary>
                    /// <para>Department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2256****</para>
                    /// </summary>
                    [NameInMap("DepartmentId")]
                    [Validation(Required=false)]
                    public long? DepartmentId { get; set; }

                    /// <summary>
                    /// <para>The department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>部门A</para>
                    /// </summary>
                    [NameInMap("DepartmentName")]
                    [Validation(Required=false)]
                    public string DepartmentName { get; set; }

                    /// <summary>
                    /// <para>The skill group list.</para>
                    /// </summary>
                    [NameInMap("GroupDOList")]
                    [Validation(Required=false)]
                    public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList> GroupDOList { get; set; }
                    public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList : TeaModel {
                        /// <summary>
                        /// <para>The skill group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6083****</para>
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        /// <summary>
                        /// <para>The skill group name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>技能组A</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                }

                /// <summary>
                /// <para>Number description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Satisfaction status. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Neither inbound nor outbound calls are enabled.  </description></item>
                /// <item><description><b>1</b>: Inbound calls are enabled.  </description></item>
                /// <item><description><b>2</b>: Outbound calls are enabled.  </description></item>
                /// <item><description><b>3</b>: Both inbound and outbound calls are enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EvaluationStatus")]
                [Validation(Required=false)]
                public int? EvaluationStatus { get; set; }

                /// <summary>
                /// <para>Incoming call flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public long? FlowId { get; set; }

                /// <summary>
                /// <para>Inbound flow name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试流程</para>
                /// </summary>
                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

                /// <summary>
                /// <para>Hotline number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571****2211</para>
                /// </summary>
                [NameInMap("HotlineNumber")]
                [Validation(Required=false)]
                public string HotlineNumber { get; set; }

                /// <summary>
                /// <para>Indicates whether the number is used for inbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("InBoundEnabled")]
                [Validation(Required=false)]
                public bool? InBoundEnabled { get; set; }

                /// <summary>
                /// <para>Number location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江杭州</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>Indicates whether the number is used for outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OutboundEnabled")]
                [Validation(Required=false)]
                public bool? OutboundEnabled { get; set; }

                /// <summary>
                /// <para>Carrier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>电信</para>
                /// </summary>
                [NameInMap("Sp")]
                [Validation(Required=false)]
                public string Sp { get; set; }

            }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Total amount of data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
