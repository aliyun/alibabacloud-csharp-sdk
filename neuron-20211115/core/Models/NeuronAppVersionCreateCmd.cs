// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class NeuronAppVersionCreateCmd : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1343424</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>升级订单功能</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("envs")]
        [Validation(Required=false)]
        public List<string> Envs { get; set; }

        [NameInMap("featureDesc")]
        [Validation(Required=false)]
        public List<NeuronAppInfoContent> FeatureDesc { get; set; }

        [NameInMap("imageUrls")]
        [Validation(Required=false)]
        public List<string> ImageUrls { get; set; }

        [NameInMap("instructionUrl")]
        [Validation(Required=false)]
        public string InstructionUrl { get; set; }

        [NameInMap("manageType")]
        [Validation(Required=false)]
        public string ManageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("mobiId")]
        [Validation(Required=false)]
        public long? MobiId { get; set; }

        [NameInMap("pbcs")]
        [Validation(Required=false)]
        public List<long?> Pbcs { get; set; }

        [NameInMap("pluginList")]
        [Validation(Required=false)]
        public List<AppPluginInfo> PluginList { get; set; }

        [NameInMap("privateInfo")]
        [Validation(Required=false)]
        public List<string> PrivateInfo { get; set; }

        [NameInMap("scopes")]
        [Validation(Required=false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("sidebar")]
        [Validation(Required=false)]
        public string Sidebar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("unbindEffect")]
        [Validation(Required=false)]
        public string UnbindEffect { get; set; }

        [NameInMap("unbindReasons")]
        [Validation(Required=false)]
        public List<string> UnbindReasons { get; set; }

        [NameInMap("updatedFeature")]
        [Validation(Required=false)]
        public List<NeuronAppInfoContent> UpdatedFeature { get; set; }

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
