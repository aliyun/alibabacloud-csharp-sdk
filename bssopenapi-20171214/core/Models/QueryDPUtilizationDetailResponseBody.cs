// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDPUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryDPUtilizationDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The detailed resource plan usage.</para>
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
                    /// <para>The deduction date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019/5/23 12:00</para>
                    /// </summary>
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    /// <summary>
                    /// <para>The total computing capacity or storage capacity of the RI or SCU during the deduction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    /// <summary>
                    /// <para>The deduct factor. This parameter is returned only if the CommodityCode parameter is set to ecsRi.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public float? DeductHours { get; set; }

                    /// <summary>
                    /// <para>The original measured amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DeductMeasure")]
                    [Validation(Required=false)]
                    public float? DeductMeasure { get; set; }

                    /// <summary>
                    /// <para>The computing capacity or storage capacity that is deducted in a pay-as-you-go instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DeductQuantity")]
                    [Validation(Required=false)]
                    public float? DeductQuantity { get; set; }

                    /// <summary>
                    /// <para>The code of the deducted service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("DeductedCommodityCode")]
                    [Validation(Required=false)]
                    public string DeductedCommodityCode { get; set; }

                    /// <summary>
                    /// <para>The ID of the deducted instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-123123</para>
                    /// </summary>
                    [NameInMap("DeductedInstanceId")]
                    [Validation(Required=false)]
                    public string DeductedInstanceId { get; set; }

                    /// <summary>
                    /// <para>The name of the deducted service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ApsaraDB RDS</para>
                    /// </summary>
                    [NameInMap("DeductedProductDetail")]
                    [Validation(Required=false)]
                    public string DeductedProductDetail { get; set; }

                    /// <summary>
                    /// <para>The ID of the RI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-123123</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance type of the deducted instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds.mysql.s3.large</para>
                    /// </summary>
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    /// <summary>
                    /// <para>The region in which the instance resides. This parameter can be left empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The billable item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PutRequest</para>
                    /// </summary>
                    [NameInMap("ResCode")]
                    [Validation(Required=false)]
                    public string ResCode { get; set; }

                    /// <summary>
                    /// <para>The UID of the deducted instance.</para>
                    /// <list type="bullet">
                    /// <item><description>If the deduction is shared, the value of this parameter indicates the UID of the deducted instance.</description></item>
                    /// <item><description>If the deduction is not shared, the value of this parameter is the same as that of the uid parameter.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1111111111</para>
                    /// </summary>
                    [NameInMap("ShareUid")]
                    [Validation(Required=false)]
                    public long? ShareUid { get; set; }

                    /// <summary>
                    /// <para>The UID of the deducted instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1111111111</para>
                    /// </summary>
                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

            }

            /// <summary>
            /// <para>The token that is used to retrieve the next page of results. You can set the LastToken parameter to this value in the next request. If null is returned, all results are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESF***zNTAw</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
