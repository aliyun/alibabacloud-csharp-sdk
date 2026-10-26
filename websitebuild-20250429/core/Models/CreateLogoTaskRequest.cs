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
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
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
        /// <para>Strictly extract the summary of the article based on the original text. Do not fabricate or modify the news data in the text, change the original meaning or news facts, or add your own opinions to the summary. Ensure that the generated summary is free of grammatical and punctuation errors. Remove information such as the reporter, correspondent, and source when generating the summary</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
