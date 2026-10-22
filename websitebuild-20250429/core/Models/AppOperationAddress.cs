// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppOperationAddress : TeaModel {
        /// <summary>
        /// <para>The action button list.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<AppOperateAction> Actions { get; set; }

        /// <summary>
        /// <para>The customer service design URL.</para>
        /// </summary>
        [NameInMap("AiCustomerConfigUrl")]
        [Validation(Required=false)]
        public string AiCustomerConfigUrl { get; set; }

        /// <summary>
        /// <para>The AI design URL.</para>
        /// </summary>
        [NameInMap("AiDesignUrl")]
        [Validation(Required=false)]
        public string AiDesignUrl { get; set; }

        /// <summary>
        /// <para>The application publishing URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://abcd.scd.wanwang.xin">https://abcd.scd.wanwang.xin</a></para>
        /// </summary>
        [NameInMap("AppPublishUrl")]
        [Validation(Required=false)]
        public string AppPublishUrl { get; set; }

        /// <summary>
        /// <para>The overview page action button list.</para>
        /// </summary>
        [NameInMap("DashboardActions")]
        [Validation(Required=false)]
        public List<AppOperateAction> DashboardActions { get; set; }

        /// <summary>
        /// <para>The professional design URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://zero.msea.aliyun.com/forward/v1/website/websiteLogin?bizId=WS20250915163734000001&callBackUrl=/Designer/index">https://zero.msea.aliyun.com/forward/v1/website/websiteLogin?bizId=WS20250915163734000001&amp;callBackUrl=/Designer/index</a></para>
        /// </summary>
        [NameInMap("DesignUrl")]
        [Validation(Required=false)]
        public string DesignUrl { get; set; }

        /// <summary>
        /// <para>The application instance logon URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://zero.msea.aliyun.com/forward/v1/website/websiteLogin?bizId=WS20250915163734000001&callBackUrl=/Admin/SiteAdmin/Index">https://zero.msea.aliyun.com/forward/v1/website/websiteLogin?bizId=WS20250915163734000001&amp;callBackUrl=/Admin/SiteAdmin/Index</a></para>
        /// </summary>
        [NameInMap("InstanceLoginUrl")]
        [Validation(Required=false)]
        public string InstanceLoginUrl { get; set; }

        /// <summary>
        /// <para>The renewal purchase URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://common-buy.aliyun.com/?orderType=RENEW&commodityCode=domain_website_public_cn&instanceId=12313213">https://common-buy.aliyun.com/?orderType=RENEW&amp;commodityCode=domain_website_public_cn&amp;instanceId=12313213</a></para>
        /// </summary>
        [NameInMap("RenewBuyUrl")]
        [Validation(Required=false)]
        public string RenewBuyUrl { get; set; }

        /// <summary>
        /// <para>The service delivery URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://zero.msea.aliyun.com/forward/v1/website/websiteLogin?bizId=WS20250915163734000001&callBackUrl=/Admin/SiteAdmin/Index">https://zero.msea.aliyun.com/forward/v1/website/websiteLogin?bizId=WS20250915163734000001&amp;callBackUrl=/Admin/SiteAdmin/Index</a></para>
        /// </summary>
        [NameInMap("ServerDeliveryUrl")]
        [Validation(Required=false)]
        public string ServerDeliveryUrl { get; set; }

        /// <summary>
        /// <para>The upgrade purchase URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://common-buy.aliyun.com/?orderType=UPGRADE&commodityCode=domain_website_public_cn&instanceId=12313213">https://common-buy.aliyun.com/?orderType=UPGRADE&amp;commodityCode=domain_website_public_cn&amp;instanceId=12313213</a></para>
        /// </summary>
        [NameInMap("UpgradeBuyUrl")]
        [Validation(Required=false)]
        public string UpgradeBuyUrl { get; set; }

    }

}
