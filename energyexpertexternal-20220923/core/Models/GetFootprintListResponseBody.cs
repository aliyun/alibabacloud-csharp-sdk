// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetFootprintListResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFootprintListResponseBodyData Data { get; set; }
        public class GetFootprintListResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// Product Detail List.
            /// </summary>
            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetFootprintListResponseBodyDataRecords> Records { get; set; }
            public class GetFootprintListResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// The amount of the product.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// Authentication status enumeration value, please refer to [link](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf).
                /// </summary>
                [NameInMap("authStatus")]
                [Validation(Required=false)]
                public long? AuthStatus { get; set; }

                /// <summary>
                /// Calculation end time.
                /// </summary>
                [NameInMap("checkEndTime")]
                [Validation(Required=false)]
                public string CheckEndTime { get; set; }

                /// <summary>
                /// Calculation start time.
                /// </summary>
                [NameInMap("checkStartTime")]
                [Validation(Required=false)]
                public string CheckStartTime { get; set; }

                /// <summary>
                /// The enterprise code.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The user who created it.
                /// </summary>
                [NameInMap("createdBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// The product ID.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// Indicates whether the demo model is a built-in model. A value of 1 indicates a true value and a value of 0 indicates a false value.
                /// </summary>
                [NameInMap("isDemoModel")]
                [Validation(Required=false)]
                public long? IsDemoModel { get; set; }

                /// <summary>
                /// The literal expression corresponding to lifeCycleType, `From Cradle to Gate` and `From Cradle to Grave`.
                /// </summary>
                [NameInMap("lifeCycle")]
                [Validation(Required=false)]
                public string LifeCycle { get; set; }

                /// <summary>
                /// 1 is `From Cradle to Gate`, and 2 is `From Cradle to Grave`.
                /// </summary>
                [NameInMap("lifeCycleType")]
                [Validation(Required=false)]
                public long? LifeCycleType { get; set; }

                /// <summary>
                /// The product name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Product category enumeration value, please refer to [Carbon Footprint Appendices](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf).
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// Unit enumeration value. Please refer to [Carbon Footprint Appendices](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf).
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// Total Pages
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
