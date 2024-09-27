// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetFootprintListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFootprintListResponseBodyData Data { get; set; }
        public class GetFootprintListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Product Detail List.</para>
            /// </summary>
            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetFootprintListResponseBodyDataRecords> Records { get; set; }
            public class GetFootprintListResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The amount of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0000000000000000000000000</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// <para>Authentication status enumeration value, please refer to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">link</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("authStatus")]
                [Validation(Required=false)]
                public long? AuthStatus { get; set; }

                /// <summary>
                /// <para>Calculation end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024/01/31</para>
                /// </summary>
                [NameInMap("checkEndTime")]
                [Validation(Required=false)]
                public string CheckEndTime { get; set; }

                /// <summary>
                /// <para>Calculation start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024/01/01</para>
                /// </summary>
                [NameInMap("checkStartTime")]
                [Validation(Required=false)]
                public string CheckStartTime { get; set; }

                /// <summary>
                /// <para>The enterprise code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C-20080808-1</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The user who created it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Energy Expert</para>
                /// </summary>
                [NameInMap("createdBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <para>The product ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the demo model is a built-in model. A value of 1 indicates a true value and a value of 0 indicates a false value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("isDemoModel")]
                [Validation(Required=false)]
                public long? IsDemoModel { get; set; }

                /// <summary>
                /// <para>The literal expression corresponding to lifeCycleType, <c>From Cradle to Gate</c> and <c>From Cradle to Grave</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>From Cradle to Gate</para>
                /// </summary>
                [NameInMap("lifeCycle")]
                [Validation(Required=false)]
                public string LifeCycle { get; set; }

                /// <summary>
                /// <para>1 is <c>From Cradle to Gate</c>, and 2 is <c>From Cradle to Grave</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("lifeCycleType")]
                [Validation(Required=false)]
                public long? LifeCycleType { get; set; }

                /// <summary>
                /// <para>The product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Carbon-footprint-demo</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Product category enumeration value, please refer to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">Carbon Footprint Appendices</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>158-159</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Unit enumeration value. Please refer to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">Carbon Footprint Appendices</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1-4</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>Total Pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06DA2909-7736-5738-AA31-ACD617D828F1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
