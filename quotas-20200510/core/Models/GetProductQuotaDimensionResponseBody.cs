// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The details of the quota dimension.</para>
        /// </summary>
        [NameInMap("QuotaDimension")]
        [Validation(Required=false)]
        public GetProductQuotaDimensionResponseBodyQuotaDimension QuotaDimension { get; set; }
        public class GetProductQuotaDimensionResponseBodyQuotaDimension : Darabonba.Model {
            /// <summary>
            /// <para>The quota dimensions of the cloud service on which the target quota depends.</para>
            /// </summary>
            [NameInMap("DependentDimensions")]
            [Validation(Required=false)]
            public List<string> DependentDimensions { get; set; }

            /// <summary>
            /// <para>The key of the quota dimension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>regionId: region</para>
            /// </description></item>
            /// <item><description><para>zoneId: zone</para>
            /// </description></item>
            /// <item><description><para>chargeType: billing method</para>
            /// </description></item>
            /// <item><description><para>networkType: network type</para>
            /// </description></item>
            /// <item><description><para>resourceType: resource type</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zoneId</para>
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
            public class GetProductQuotaDimensionResponseBodyQuotaDimensionDimensionValueDetail : Darabonba.Model {
                /// <summary>
                /// <para>The name of the quota dimension value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the quota dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of quota dimension values.</para>
            /// </summary>
            [NameInMap("DimensionValues")]
            [Validation(Required=false)]
            public List<string> DimensionValues { get; set; }

            /// <summary>
            /// <para>The name of the quota dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zone</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FA5F0E2-368E-4BA4-A8D0-6060FC6BB8F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

