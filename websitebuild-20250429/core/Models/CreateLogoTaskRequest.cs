// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateLogoTaskRequest : TeaModel {
        [NameInMap("LogoVersion")]
        [Validation(Required=false)]
        public string LogoVersion { get; set; }

        [NameInMap("NegativePrompt")]
        [Validation(Required=false)]
        public string NegativePrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;ehpcutilParam\&quot;:\&quot;sched job_submit --commandline \\\&quot;/ehpcdata/data/usersTest/huangqiaoyi-1725933699384/huangqiaoyi-1725933699384.slurm\\\&quot; --runasuser TestGfjnSimworks\&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
