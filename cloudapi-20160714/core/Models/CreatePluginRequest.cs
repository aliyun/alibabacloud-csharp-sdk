// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreatePluginRequest : TeaModel {
        /// <summary>
        /// <para>The description of the plug-in. The description can contain a maximum of 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createPlugin</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The plug-in definition. Supported formats: JSON and YAML.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Plugin definition</para>
        /// </summary>
        [NameInMap("PluginData")]
        [Validation(Required=false)]
        public string PluginData { get; set; }

        /// <summary>
        /// <para>The name of the plug-in. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (_). However, it cannot start with an underscore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewCors</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// <para>The type of the plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ipControl: IP address-based access control</b></description></item>
        /// <item><description><b>trafficControl: throttling</b></description></item>
        /// <item><description><b>backendSignature: backend signature</b></description></item>
        /// <item><description><b>jwtAuth</b> :JWT (OpenId Connect) authentication</description></item>
        /// <item><description><b>cors</b> :cross-origin resource sharing (CORS)</description></item>
        /// <item><description><b>caching</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cors</para>
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

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
        public List<CreatePluginRequestTag> Tag { get; set; }
        public class CreatePluginRequestTag : TeaModel {
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
