// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppAssistantAgentsRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The platform type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChannelOps</para>
        /// </summary>
        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

    }

}
