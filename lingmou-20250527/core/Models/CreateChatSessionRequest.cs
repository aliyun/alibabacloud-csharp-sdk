// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateChatSessionRequest : TeaModel {
        /// <summary>
        /// <para>需要在<a href="https://common-buy.aliyun.com/?spm=a2c4g.11186623.0.0.457876812ETi6y&commodityCode=avatar_2dchat_public_cn">数字人实时交互服务</a>购买完成对应的服务购买，当前有可用的服务时，前往阿里云-<a href="https://billing-cost.console.aliyun.com/order/list">我的订单</a>页面对应订单详情下进行查询</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-9t946y43m1d</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>灵眸平台颁发的个人凭证（在使用端渲染数字人的场景下必填）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9be4b25c2d38c409c376ffd2372be1</para>
        /// </summary>
        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <para>运行SDK的平台（在使用端渲染数字人的场景下必填）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web | Android | iOS</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
