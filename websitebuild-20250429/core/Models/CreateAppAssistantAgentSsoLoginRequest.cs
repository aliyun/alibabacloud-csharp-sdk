// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppAssistantAgentSsoLoginRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250821161210000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The platform type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        /// <summary>
        /// <para>The target URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://172.16.70.16:9410/metrics">http://172.16.70.16:9410/metrics</a></para>
        /// </summary>
        [NameInMap("TargetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

    }

}
