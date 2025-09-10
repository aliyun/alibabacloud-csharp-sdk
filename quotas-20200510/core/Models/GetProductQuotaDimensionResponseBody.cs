// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the quota dimension.</para>
        /// </summary>
        [NameInMap("QuotaDimension")]
        [Validation(Required=false)]
        public GetProductQuotaDimensionResponseBodyQuotaDimension QuotaDimension { get; set; }
        public class GetProductQuotaDimensionResponseBodyQuotaDimension : TeaModel {
            /// <summary>
            /// <para>The quota dimensions on which the quota dimension that you want to query is dependent.</para>
            /// </summary>
            [NameInMap("DependentDimensions")]
            [Validation(Required=false)]
            public List<string> DependentDimensions { get; set; }

            /// <summary>
            /// <para>The key of the quota dimension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>regionId: the region ID.</description></item>
            /// <item><description>zoneId: the zone ID.</description></item>
            /// <item><description>chargeType: the billing method.</description></item>
            /// <item><description>networkType: the network type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// <para>The details of the quota dimension value.</para>
            /// </summary>
            [NameInMap("DimensionValueDetail")]
            [Validation(Required=false)]
            public List<GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail> DimensionValueDetail { get; set; }
            public class GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail : TeaModel {
                /// <summary>
                /// <para>The name of the quota dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the quota dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The values of the quota dimension.</para>
            /// </summary>
            [NameInMap("DimensionValues")]
            [Validation(Required=false)]
            public List<string> DimensionValues { get; set; }

            /// <summary>
            /// <para>The name of the quota dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FA5F0E2-368E-4BA4-A8D0-6060FC6BB8F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
