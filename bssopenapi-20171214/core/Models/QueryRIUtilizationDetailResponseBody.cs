// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRIUtilizationDetailResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRIUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryRIUtilizationDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The usage details of the RI.
            /// </summary>
            [NameInMap("DetailList")]
            [Validation(Required=false)]
            public QueryRIUtilizationDetailResponseBodyDataDetailList DetailList { get; set; }
            public class QueryRIUtilizationDetailResponseBodyDataDetailList : TeaModel {
                [NameInMap("DetailList")]
                [Validation(Required=false)]
                public List<QueryRIUtilizationDetailResponseBodyDataDetailListDetailList> DetailList { get; set; }
                public class QueryRIUtilizationDetailResponseBodyDataDetailListDetailList : TeaModel {
                    /// <summary>
                    /// The time when the fees are deducted by using the RI.
                    /// </summary>
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    /// <summary>
                    /// The total amount of computing power of the RI or capacity of SCU in the time period.
                    /// </summary>
                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    /// <summary>
                    /// The deduct factor. This parameter is returned only if the RICommodityCode parameter is set to ecsRi.
                    /// </summary>
                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public string DeductHours { get; set; }

                    /// <summary>
                    /// The computing power or capacity of the pay-as-you-go instance whose fees are deducted by using the RI.
                    /// </summary>
                    [NameInMap("DeductQuantity")]
                    [Validation(Required=false)]
                    public float? DeductQuantity { get; set; }

                    /// <summary>
                    /// The code of the service whose fees are deducted by using the RI.
                    /// </summary>
                    [NameInMap("DeductedCommodityCode")]
                    [Validation(Required=false)]
                    public string DeductedCommodityCode { get; set; }

                    /// <summary>
                    /// The ID of the instance whose fees are deducted by using the RI.
                    /// </summary>
                    [NameInMap("DeductedInstanceId")]
                    [Validation(Required=false)]
                    public string DeductedInstanceId { get; set; }

                    /// <summary>
                    /// The name of the service whose fees are deducted by using the RI.
                    /// </summary>
                    [NameInMap("DeductedProductDetail")]
                    [Validation(Required=false)]
                    public string DeductedProductDetail { get; set; }

                    /// <summary>
                    /// The instance type of the instance whose fees are deducted by using the RI.
                    /// </summary>
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    /// <summary>
                    /// The ID of the RI.
                    /// </summary>
                    [NameInMap("RIInstanceId")]
                    [Validation(Required=false)]
                    public string RIInstanceId { get; set; }

                }

            }

            /// <summary>
            /// The number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
