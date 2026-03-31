// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateProjectDefaultQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The default computing quota that is used to allocate computing resources, the jobs that are initiated by this project consume the computing resources in the default quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os_PayAsYouGoQuota</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

    }

}
