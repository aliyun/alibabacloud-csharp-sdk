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
            /// <para>The type of the source instance. Valid values: <b>MySQL</b>, <b>PolarDB</b>, <b>DRDS</b>, and <b>Oracle</b>.</para>
            /// <remarks>
            /// <para> Default value: <b>MySQL</b>.</para>
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
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The <b>ClientToken</b> parameter can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <para>The billing method of the change tracking instance.</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify this parameter only if you set the PayType parameter to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the change tracking instance. The region ID is the same as that of the source instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The subscription length.</para>
        /// <list type="bullet">
        /// <item><description>If the billing cycle is <b>Year</b>, the value range is <b>1 to 5</b>.</description></item>
        /// <item><description>If the billing cycle is <b>Month</b>, the value range is <b>1 to 60</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify this parameter only if you set the PayType parameter to <b>Prepaid</b>.</para>
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
