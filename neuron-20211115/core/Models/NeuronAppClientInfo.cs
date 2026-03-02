// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class NeuronAppClientInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>module_58mkf3jj::page_gbnxyuh5</para>
        /// </summary>
        [NameInMap("appEntry")]
        [Validation(Required=false)]
        public string AppEntry { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("mobiInfo")]
        [Validation(Required=false)]
        public MobiInfo MobiInfo { get; set; }

        [NameInMap("pluginList")]
        [Validation(Required=false)]
        public List<AppPluginInfo> PluginList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("sidebar")]
        [Validation(Required=false)]
        public string Sidebar { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
