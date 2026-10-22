// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateLogoTaskRequest : TeaModel {
        /// <summary>
        /// <para>The logo generation version number. Different versions use different parameter parsing methods.</para>
        /// </summary>
        [NameInMap("LogoVersion")]
        [Validation(Required=false)]
        public string LogoVersion { get; set; }

        /// <summary>
        /// <para>The negative prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Do not generate politically related image content</para>
        /// </summary>
        [NameInMap("NegativePrompt")]
        [Validation(Required=false)]
        public string NegativePrompt { get; set; }

        /// <summary>
        /// <para>The task parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ehpcutilParam\&quot;:\&quot;sched job_submit --commandline \\\&quot;/ehpcdata/data/usersTest/huangqiaoyi-1725933699384/huangqiaoyi-1725933699384.slurm\\\&quot; --runasuser TestGfjnSimworks\&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The positive prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Strictly follow the original text to extract the summary of the manuscript. Do not arbitrarily fabricate or modify the news data presented in the text. Do not change the meaning or the news facts of the original text. Do not add your own opinions to the summary. Ensure the generated summary is free of grammatical and punctuation errors. When generating the summary, remove information such as the reporter, correspondent, and article source</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
