// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AttachGroupPluginRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08ae4aa0f95e4321849ee57f4e0b3077</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the plug-in to be bound.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05df2b52a3644a3a8b1935ab8ab59e9d</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The environment in which the API is requested. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b>: the production environment</description></item>
        /// <item><description><b>PRE</b>: the pre-release environment</description></item>
        /// <item><description><b>TEST</b>: the test environment</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
