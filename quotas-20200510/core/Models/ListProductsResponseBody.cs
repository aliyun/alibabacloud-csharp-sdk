// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records that are returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position at which the query ends. An empty value indicates that all data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the Alibaba Cloud services.</para>
        /// </summary>
        [NameInMap("ProductInfo")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProductInfo> ProductInfo { get; set; }
        public class ListProductsResponseBodyProductInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Alibaba Cloud service supports general quotas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>support: The Alibaba Cloud service supports general quotas.</description></item>
            /// <item><description>unsupport: The Alibaba Cloud service does not support general quotas.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>support</para>
            /// </summary>
            [NameInMap("CommonQuotaSupport")]
            [Validation(Required=false)]
            public string CommonQuotaSupport { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is discontinued and is not recommended.</para>
            /// </remarks>
            /// <para>Indicates whether the Alibaba Cloud service supports dynamic quota adjustment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            /// <summary>
            /// <para>Indicates whether the Alibaba Cloud service supports API rate limits. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>support: The Alibaba Cloud service supports API rate limits.</description></item>
            /// <item><description>unsupport: The Alibaba Cloud service does not support API rate limits.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unsupport</para>
            /// </summary>
            [NameInMap("FlowControlSupport")]
            [Validation(Required=false)]
            public string FlowControlSupport { get; set; }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service (ECS)</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The English name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("ProductNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            /// <summary>
            /// <para>The ID of the service category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SecondCategoryId")]
            [Validation(Required=false)]
            public long? SecondCategoryId { get; set; }

            /// <summary>
            /// <para>The name of the service category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute</para>
            /// </summary>
            [NameInMap("SecondCategoryName")]
            [Validation(Required=false)]
            public string SecondCategoryName { get; set; }

            /// <summary>
            /// <para>The English name of the service category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute</para>
            /// </summary>
            [NameInMap("SecondCategoryNameEn")]
            [Validation(Required=false)]
            public string SecondCategoryNameEn { get; set; }

            /// <summary>
            /// <para>Indicates whether the Alibaba Cloud service supports whitelist quotas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>support: The Alibaba Cloud service supports whitelist quotas.</description></item>
            /// <item><description>unsupport: The Alibaba Cloud service does not support whitelist quotas.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>support</para>
            /// </summary>
            [NameInMap("WhiteListLabelQuotaSupport")]
            [Validation(Required=false)]
            public string WhiteListLabelQuotaSupport { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DA9C136-11BC-4C39-ADC6-B86276128072</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that are returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
