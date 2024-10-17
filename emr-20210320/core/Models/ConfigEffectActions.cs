// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ConfigEffectActions : TeaModel {
        /// <summary>
        /// <para>配置生效动作。</para>
        /// 
        /// <b>Example:</b>
        /// <para>restart</para>
        /// </summary>
        [NameInMap("ConfigEffectAction")]
        [Validation(Required=false)]
        public string ConfigEffectAction { get; set; }

        /// <summary>
        /// <para>配置生效配置文件。</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ConfigFiles")]
        [Validation(Required=false)]
        public List<string> ConfigFiles { get; set; }

    }

}
