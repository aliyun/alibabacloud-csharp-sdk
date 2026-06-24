// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InstallUserPluginsRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom plugins to install.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {&quot;name&quot;: &quot;pluginName1.zip&quot;},     {&quot;name&quot;: &quot;pluginName2.zip&quot;} ]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
