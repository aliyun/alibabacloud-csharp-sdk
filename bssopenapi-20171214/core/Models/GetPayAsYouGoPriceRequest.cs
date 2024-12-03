// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetPayAsYouGoPriceRequest : TeaModel {
        /// <summary>
        /// <para>The details of pricing modules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public List<GetPayAsYouGoPriceRequestModuleList> ModuleList { get; set; }
        public class GetPayAsYouGoPriceRequestModuleList : TeaModel {
            /// <summary>
            /// <para>The configuration of the Nth pricing module. Valid values of N: 1 to 50. Format: AA:aa,BB:bb. The values of AA and BB are the property IDs of the pricing module. The values of aa and bb are the property values of the pricing module.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/96469.html">DescribePricingModule</a> operation to obtain the configuration parameters of the pricing module.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceType:ecs.g5.xlarge,IoOptimized:IoOptimized,ImageOs:linux</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The code of the Nth pricing module.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/96469.html">DescribePricingModule</a> operation to obtain the module code.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceType</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The price type of the Nth pricing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Hour: hourly price</description></item>
            /// <item><description>Usage: usage price</description></item>
            /// <item><description>Month: monthly price</description></item>
            /// <item><description>Year: annual price</description></item>
            /// </list>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/96469.html">DescribePricingModule</a> operation to obtain the configuration parameters of the pricing module.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("PriceType")]
            [Validation(Required=false)]
            public string PriceType { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The billing method. Set the value to PayAsYouGo.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
