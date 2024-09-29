// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCommercialStatusRequest : TeaModel {
        /// <summary>
        /// <para>The product code.</para>
        /// <list type="bullet">
        /// <item><description>arms_app_post</description></item>
        /// <item><description>arms_web_post</description></item>
        /// <item><description>arms_promethues_public_cn</description></item>
        /// <item><description>prometheus_pay_public_cn</description></item>
        /// <item><description>xtrace</description></item>
        /// <item><description>arms_serverless_public_cn</description></item>
        /// <item><description>arms_rumserverless_public_cn</description></item>
        /// <item><description>prometheus_serverless_public_cn</description></item>
        /// <item><description>xtrace_serverless_public_cn</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms_app_post</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
