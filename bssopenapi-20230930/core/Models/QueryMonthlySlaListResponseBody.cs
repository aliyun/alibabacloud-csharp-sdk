// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryMonthlySlaListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryMonthlySlaListResponseBodyData> Data { get; set; }
        public class QueryMonthlySlaListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>99.9155</para>
            /// </summary>
            [NameInMap("AvailableRate")]
            [Validation(Required=false)]
            public double? AvailableRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9b7***9413</para>
            /// </summary>
            [NameInMap("DamagedId")]
            [Validation(Required=false)]
            public string DamagedId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSSBAG-cn-0xl0n****003</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202603</para>
            /// </summary>
            [NameInMap("Month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>365.00</para>
            /// </summary>
            [NameInMap("MonthlyServiceCharge")]
            [Validation(Required=false)]
            public double? MonthlyServiceCharge { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SLApei f</para>
            /// </summary>
            [NameInMap("PayDescription")]
            [Validation(Required=false)]
            public string PayDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PayRate")]
            [Validation(Required=false)]
            public double? PayRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayStatus")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36.5</para>
            /// </summary>
            [NameInMap("ShouldPaySum")]
            [Validation(Required=false)]
            public double? ShouldPaySum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
