// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRIUtilizationDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRIUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryRIUtilizationDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage details of the RI.</para>
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
                    /// <para>The time when the fees are deducted by using the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-05-23 12:00:00</para>
                    /// </summary>
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    /// <summary>
                    /// <para>The total amount of computing power of the RI or capacity of SCU in the time period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    /// <summary>
                    /// <para>The deduct factor. This parameter is returned only if the RICommodityCode parameter is set to ecsRi.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public string DeductHours { get; set; }

                    /// <summary>
                    /// <para>The computing power or capacity of the pay-as-you-go instance whose fees are deducted by using the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DeductQuantity")]
                    [Validation(Required=false)]
                    public float? DeductQuantity { get; set; }

                    /// <summary>
                    /// <para>The code of the service whose fees are deducted by using the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("DeductedCommodityCode")]
                    [Validation(Required=false)]
                    public string DeductedCommodityCode { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance whose fees are deducted by using the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>safdffghfgh</para>
                    /// </summary>
                    [NameInMap("DeductedInstanceId")]
                    [Validation(Required=false)]
                    public string DeductedInstanceId { get; set; }

                    /// <summary>
                    /// <para>The name of the service whose fees are deducted by using the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ApsaraDB RDS</para>
                    /// </summary>
                    [NameInMap("DeductedProductDetail")]
                    [Validation(Required=false)]
                    public string DeductedProductDetail { get; set; }

                    /// <summary>
                    /// <para>The instance type of the instance whose fees are deducted by using the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds.mysql.s3.large</para>
                    /// </summary>
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    /// <summary>
                    /// <para>The ID of the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>324253645</para>
                    /// </summary>
                    [NameInMap("RIInstanceId")]
                    [Validation(Required=false)]
                    public string RIInstanceId { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF58589C-A06C-4224-8615-7797E6474FA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
