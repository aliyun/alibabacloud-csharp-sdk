// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetSubscriptionPriceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance for which you want to inquire about the price. This parameter is required in upgrade scenarios to obtain the configurations of the instance before the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-khkjhxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of pricing modules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public List<GetSubscriptionPriceRequestModuleList> ModuleList { get; set; }
        public class GetSubscriptionPriceRequestModuleList : TeaModel {
            /// <summary>
            /// <para>The configuration of the nth pricing module. Valid values of n: 1 to 50. Format: AA:aa,BB:bb. AA and BB are the identifiers of the pricing module attributes, and aa and bb are the attribute values of the pricing module attributes.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageCode:version_1</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The identifier of the nth pricing module.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageCode</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The change status of the pricing module for this inquiry. This parameter is required only when the order type is Upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: add.</description></item>
            /// <item><description>2: modify. If the configuration of the pricing module changes in an upgrade scenario, you must explicitly specify this value.</description></item>
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
            /// <para>The identifier of the specified resource. This parameter is required only for the upgrade and configuration change of specific products. For example, if you change the configuration of a cloud disk, you can use Tag to identify the ID of the specific cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213213123</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NewOrder: new purchase.</description></item>
        /// <item><description>Renewal: renewal.</description></item>
        /// <item><description>Upgrade: upgrade.</description></item>
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
        /// <para>The product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type. Whether this parameter is required depends on the price inquiry documentation of the specific product.</para>
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
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The service period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServicePeriodQuantity")]
        [Validation(Required=false)]
        public int? ServicePeriodQuantity { get; set; }

        /// <summary>
        /// <para>The unit of the service period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year: years.</description></item>
        /// <item><description>Month: months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("ServicePeriodUnit")]
        [Validation(Required=false)]
        public string ServicePeriodUnit { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid value: Subscription (subscription).</para>
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
