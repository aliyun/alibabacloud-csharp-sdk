// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class EditPluginConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("PluginConfig")]
        [Validation(Required=false)]
        public string PluginConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通义万相通过文字描述生成图片</para>
        /// </summary>
        [NameInMap("PluginDesc")]
        [Validation(Required=false)]
        public string PluginDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliplayer-react</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alisecguard</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

    }

}
