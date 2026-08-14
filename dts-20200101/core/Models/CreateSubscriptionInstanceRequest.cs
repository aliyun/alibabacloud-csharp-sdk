// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateSubscriptionInstanceRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public CreateSubscriptionInstanceRequestSourceEndpoint SourceEndpoint { get; set; }
        public class CreateSubscriptionInstanceRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>数据订阅的实例类型，取值为：<b>MySQL</b>、<b>PolarDB</b>、<b>DRDS</b>、<b>Oracle</b>。</para>
            /// <remarks>
            /// <para>默认取值为：<b>MySQL</b>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter. This parameter will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a value from your client to make sure that the value is unique among different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go. This is the default value.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing method of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: annual subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when PayType is set to <b>Prepaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID. Set this parameter to the region where the subscription object resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region to which the change tracking instance belongs. You do not need to specify this parameter. This parameter will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The purchase duration of the subscription instance.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method is set to <b>Year</b> (annual subscription), the valid values are <b>1 to 5</b>.</description></item>
        /// <item><description>If the billing method is set to <b>Month</b> (monthly subscription), the valid values are <b>1 to 60</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when PayType is set to <b>Prepaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
