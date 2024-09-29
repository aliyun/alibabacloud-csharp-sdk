// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCommercialStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49C82193-E991-5F6A-AF3E-1664D8D05CA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The commercialization status of the service.</para>
        /// </summary>
        [NameInMap("UserAndCommodityStatus")]
        [Validation(Required=false)]
        public GetCommercialStatusResponseBodyUserAndCommodityStatus UserAndCommodityStatus { get; set; }
        public class GetCommercialStatusResponseBodyUserAndCommodityStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether you are using the Basic Edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Basic")]
            [Validation(Required=false)]
            public bool? Basic { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Indicates whether the service is activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>info</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

            /// <summary>
            /// <para>The number of days during which the service is free of charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FreeDays")]
            [Validation(Required=false)]
            public long? FreeDays { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("Lable")]
            [Validation(Required=false)]
            public string Lable { get; set; }

            /// <summary>
            /// <para>The commercialization status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The service is activated.</description></item>
            /// <item><description>Abnormal: An exception occurs during activation.</description></item>
            /// <item><description>Free: The service is not activated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
