// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductsResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The maximum number of entries returned for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position of the returned query data. An empty value indicates that all data has been queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the Alibaba Cloud service.</para>
        /// </summary>
        [NameInMap("ProductInfo")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProductInfo> ProductInfo { get; set; }
        public class ListProductsResponseBodyProductInfo : Darabonba.Model {
            /// <summary>
            /// <para>Specifies whether general quotas are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>support: Supported.</para>
            /// </description></item>
            /// <item><description><para>unsupport: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>support</para>
            /// </summary>
            [NameInMap("CommonQuotaSupport")]
            [Validation(Required=false)]
            public string CommonQuotaSupport { get; set; }

            /// <summary>
            /// <para><notice><b>[Deprecated]</b> We recommend that you do not use this parameter.</notice></para>
            /// <para>Specifies whether dynamic quota adjustment is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            /// <summary>
            /// <para>Specifies whether API rate limits are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>support: Supported.</para>
            /// </description></item>
            /// <item><description><para>unsupport: Not supported.</para>
            /// </description></item>
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
            /// <para>Specifies whether privileges are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>support: Supported.</para>
            /// </description></item>
            /// <item><description><para>unsupport: Not supported.</para>
            /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DA9C136-11BC-4C39-ADC6-B86276128072</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

