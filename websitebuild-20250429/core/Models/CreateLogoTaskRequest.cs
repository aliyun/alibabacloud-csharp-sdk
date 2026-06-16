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

        /// <summary>
        /// <para>The negative prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>不生成政治相关图片内容</para>
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
        /// <para>请严格遵照原文提取稿件的摘要，不要随意捏造和修改文中出现的新闻数据，不要改变原文的意思和新闻事实，不要在摘要中添加自己的观点。生成的摘要不要出现语法和标点的错误。在生成摘要时请去掉里面的记者、通讯员、稿件来源等信息。</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
