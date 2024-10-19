// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyPluginRequest : TeaModel {
        /// <summary>
        /// <para>The description of the plug-in. The description can contain a maximum of 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modify plugin first</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The statement that is used to modify the plug-in definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Plugin definition</para>
        /// </summary>
        [NameInMap("PluginData")]
        [Validation(Required=false)]
        public string PluginData { get; set; }

        /// <summary>
        /// <para>The ID of the plug-in whose information you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a96926e82f994915a8da40a119374537</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The name of the plug-in. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (_). However, it cannot start with an underscore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modifyCors</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The tag of objects that match the rule. You can specify multiple tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Key， Value</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ModifyPluginRequestTag> Tag { get; set; }
        public class ModifyPluginRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <para>N can be an integer from 1 to 20.``</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <para>N can be an integer from 1 to 20.``</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot; \&quot;</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
