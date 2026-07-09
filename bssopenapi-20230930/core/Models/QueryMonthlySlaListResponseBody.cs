// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryMonthlySlaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryMonthlySlaListResponseBodyData> Data { get; set; }
        public class QueryMonthlySlaListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The service availability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99.9155</para>
            /// </summary>
            [NameInMap("AvailableRate")]
            [Validation(Required=false)]
            public double? AvailableRate { get; set; }

            /// <summary>
            /// <para>The unique identifier of the damage record, which is used for targeted compensation application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b7***9413</para>
            /// </summary>
            [NameInMap("DamagedId")]
            [Validation(Required=false)]
            public string DamagedId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSSBAG-cn-0xl0n****003</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The month in yyyyMM format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202603</para>
            /// </summary>
            [NameInMap("Month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// <para>The monthly service charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365.00</para>
            /// </summary>
            [NameInMap("MonthlyServiceCharge")]
            [Validation(Required=false)]
            public double? MonthlyServiceCharge { get; set; }

            /// <summary>
            /// <para>The compensation description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLA赔付</para>
            /// </summary>
            [NameInMap("PayDescription")]
            [Validation(Required=false)]
            public string PayDescription { get; set; }

            /// <summary>
            /// <para>The compensation ratio. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PayRate")]
            [Validation(Required=false)]
            public double? PayRate { get; set; }

            /// <summary>
            /// <para>The compensation status. Valid values: 0 (uncompensated) and 1 (compensated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayStatus")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The compensation amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36.5</para>
            /// </summary>
            [NameInMap("ShouldPaySum")]
            [Validation(Required=false)]
            public double? ShouldPaySum { get; set; }

        }

        /// <summary>
        /// <para>The response metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
