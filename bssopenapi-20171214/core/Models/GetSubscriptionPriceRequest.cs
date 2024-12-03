// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetSubscriptionPriceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance for which the price is queried. This parameter is required if you upgrade an instance. You can specify this parameter to obtain the pre-upgrade configurations of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-khkjhxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The information about the pricing module.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public List<GetSubscriptionPriceRequestModuleList> ModuleList { get; set; }
        public class GetSubscriptionPriceRequestModuleList : TeaModel {
            /// <summary>
            /// <para>The configurations of the Nth pricing module. Valid values of N: 1 to 50. Format: AA:aa,BB:bb. The values of AA and BB are the property IDs of the pricing module. The values of aa and bb are the property values of the pricing module.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageCode:version_1</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The identifier of the Nth pricing module.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageCode</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The status of the pricing module. This parameter is required only if the order type is Upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: adds one or more instances.</description></item>
            /// <item><description>2: modifies the configurations of an instance. In the upgrade scenario, if the configurations of the pricing module change, you must specify this value for the parameter.</description></item>
            /// </list>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ModuleStatus")]
            [Validation(Required=false)]
            public int? ModuleStatus { get; set; }

            /// <summary>
            /// <para>The tag of the specified resource. This parameter is required only if you upgrade or modify the configurations of an Alibaba Cloud service. For example, if you want to modify the configurations of a disk, you can use a tag to identify the ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213213123</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The type of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NewOrder: purchases an instance of an Alibaba Cloud service.</description></item>
        /// <item><description>Renewal: renews an instance of an Alibaba Cloud service.</description></item>
        /// <item><description>Upgrade: upgrades an instance of an Alibaba Cloud service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewOrder</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The code of the service. For more information about the service code, see <b>Codes of Alibaba Cloud Services</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service. Specify the parameter based on the pricing document of the specific service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

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
        /// <para>The service duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServicePeriodQuantity")]
        [Validation(Required=false)]
        public int? ServicePeriodQuantity { get; set; }

        /// <summary>
        /// <para>The unit of the service duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("ServicePeriodUnit")]
        [Validation(Required=false)]
        public string ServicePeriodUnit { get; set; }

        /// <summary>
        /// <para>The billing method. Set the value to Subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
