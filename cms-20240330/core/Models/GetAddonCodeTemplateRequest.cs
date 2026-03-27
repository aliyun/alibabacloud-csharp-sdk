// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonCodeTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Client</para>
        /// </summary>
        [NameInMap("environmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
