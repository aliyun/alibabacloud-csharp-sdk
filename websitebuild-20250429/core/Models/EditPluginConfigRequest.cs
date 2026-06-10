// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class EditPluginConfigRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Plugin configuration</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("PluginConfig")]
        [Validation(Required=false)]
        public string PluginConfig { get; set; }

        /// <summary>
        /// <para>Plugin description</para>
        /// 
        /// <b>Example:</b>
        /// <para>根据关键字查询相关的Github Repositories</para>
        /// </summary>
        [NameInMap("PluginDesc")]
        [Validation(Required=false)]
        public string PluginDesc { get; set; }

        /// <summary>
        /// <para>Plugin ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliplayer-react</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Plugin name</para>
        /// 
        /// <b>Example:</b>
        /// <para>alisecguard</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

    }

}
