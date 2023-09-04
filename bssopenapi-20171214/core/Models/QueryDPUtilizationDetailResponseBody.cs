// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDPUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryDPUtilizationDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The detailed resource plan usage.
            /// </summary>
            [NameInMap("DetailList")]
            [Validation(Required=false)]
            public QueryDPUtilizationDetailResponseBodyDataDetailList DetailList { get; set; }
            public class QueryDPUtilizationDetailResponseBodyDataDetailList : TeaModel {
                [NameInMap("DetailList")]
                [Validation(Required=false)]
                public List<QueryDPUtilizationDetailResponseBodyDataDetailListDetailList> DetailList { get; set; }
                public class QueryDPUtilizationDetailResponseBodyDataDetailListDetailList : TeaModel {
                    /// <summary>
                    /// The deduction date.
                    /// </summary>
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    /// <summary>
                    /// The total computing capacity or storage capacity of the RI or SCU during the deduction.
                    /// </summary>
                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    /// <summary>
                    /// The deduct factor. This parameter is returned only if the CommodityCode parameter is set to ecsRi.
                    /// </summary>
                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public float? DeductHours { get; set; }

                    /// <summary>
                    /// The original measured amount.
                    /// </summary>
                    [NameInMap("DeductMeasure")]
                    [Validation(Required=false)]
                    public float? DeductMeasure { get; set; }

                    /// <summary>
                    /// The computing capacity or storage capacity that is deducted in a pay-as-you-go instance.
                    /// </summary>
                    [NameInMap("DeductQuantity")]
                    [Validation(Required=false)]
                    public float? DeductQuantity { get; set; }

                    /// <summary>
                    /// The code of the deducted service.
                    /// </summary>
                    [NameInMap("DeductedCommodityCode")]
                    [Validation(Required=false)]
                    public string DeductedCommodityCode { get; set; }

                    /// <summary>
                    /// The ID of the deducted instance.
                    /// </summary>
                    [NameInMap("DeductedInstanceId")]
                    [Validation(Required=false)]
                    public string DeductedInstanceId { get; set; }

                    /// <summary>
                    /// The name of the deducted service.
                    /// </summary>
                    [NameInMap("DeductedProductDetail")]
                    [Validation(Required=false)]
                    public string DeductedProductDetail { get; set; }

                    /// <summary>
                    /// The ID of the RI.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The instance type of the deducted instance.
                    /// </summary>
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    /// <summary>
                    /// The region in which the instance resides. This parameter can be left empty.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The billable item.
                    /// </summary>
                    [NameInMap("ResCode")]
                    [Validation(Required=false)]
                    public string ResCode { get; set; }

                    /// <summary>
                    /// The UID of the deducted instance.
                    /// 
                    /// *   If the deduction is shared, the value of this parameter indicates the UID of the deducted instance.
                    /// *   If the deduction is not shared, the value of this parameter is the same as that of the uid parameter.
                    /// </summary>
                    [NameInMap("ShareUid")]
                    [Validation(Required=false)]
                    public long? ShareUid { get; set; }

                    /// <summary>
                    /// The UID of the deducted instance.
                    /// </summary>
                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

            }

            /// <summary>
            /// The token that is used to retrieve the next page of results. You can set the LastToken parameter to this value in the next request. If null is returned, all results are queried.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The error message.
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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
