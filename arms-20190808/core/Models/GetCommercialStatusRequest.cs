// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCommercialStatusRequest : TeaModel {
        /// <summary>
        /// The product code.
        /// 
        /// *   arms_app_post
        /// *   arms_web_post
        /// *   arms_promethues_public_cn
        /// *   prometheus_pay_public_cn
        /// *   xtrace
        /// *   arms_serverless_public_cn
        /// *   arms_rumserverless_public_cn
        /// *   prometheus_serverless_public_cn
        /// *   xtrace_serverless_public_cn
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
