// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppPublishStatusRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Deployment ticket ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4998717</para>
        /// </summary>
        [NameInMap("DeployOrderId")]
        [Validation(Required=false)]
        public long? DeployOrderId { get; set; }

        /// <summary>
        /// <para>Website domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("WebsiteDomain")]
        [Validation(Required=false)]
        public string WebsiteDomain { get; set; }

    }

}
