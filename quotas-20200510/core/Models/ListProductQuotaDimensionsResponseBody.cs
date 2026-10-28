// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotaDimensionsResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The maximum number of entries returned for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that indicates the position of the returned data. If this parameter is not returned, it indicates that all data has been queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The quota dimensions.</para>
        /// </summary>
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<ListProductQuotaDimensionsResponseBodyQuotaDimensions> QuotaDimensions { get; set; }
        public class ListProductQuotaDimensionsResponseBodyQuotaDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The quota dimensions on which the target quota dimension depends.</para>
            /// </summary>
            [NameInMap("DependentDimensions")]
            [Validation(Required=false)]
            public List<string> DependentDimensions { get; set; }

            /// <summary>
            /// <para>The key of the quota dimension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>regionId: the region ID.</para>
            /// </description></item>
            /// <item><description><para>zoneId: the zone ID.</para>
            /// </description></item>
            /// <item><description><para>chargeType: the billing method.</para>
            /// </description></item>
            /// <item><description><para>networkType: the network type.</para>
            /// </description></item>
            /// <item><description><para>resourceType: the resource type.</para>
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
            public List<ListProductQuotaDimensionsResponseBodyQuotaDimensionsDimensionValueDetail> DimensionValueDetail { get; set; }
            public class ListProductQuotaDimensionsResponseBodyQuotaDimensionsDimensionValueDetail : Darabonba.Model {
                /// <summary>
                /// <para>The quota dimensions on which the target quota dimension depends.</para>
                /// </summary>
                [NameInMap("DependentDimensions")]
                [Validation(Required=false)]
                public List<ListProductQuotaDimensionsResponseBodyQuotaDimensionsDimensionValueDetailDependentDimensions> DependentDimensions { get; set; }
                public class ListProductQuotaDimensionsResponseBodyQuotaDimensionsDimensionValueDetailDependentDimensions : Darabonba.Model {
                    /// <summary>
                    /// <para>The key of the quota dimension on which the target quota dimension depends.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regionId</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the quota dimension on which the target quota dimension depends.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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

            /// <summary>
            /// <para>Specifies whether the quota dimension is required when you query quota dimensions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The quota dimension is required.</para>
            /// </description></item>
            /// <item><description><para>false: The quota dimension is optional.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Requisite")]
            [Validation(Required=false)]
            public bool? Requisite { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ED584FB-ECBF-4A2A-969D-F54D25EFABF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

