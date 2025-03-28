// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateSourceConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://api.devsapp.cn/v3/packages/start-modelscope-v3/zipball/0.1.6">https://api.devsapp.cn/v3/packages/start-modelscope-v3/zipball/0.1.6</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>start-springboot-cap</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
