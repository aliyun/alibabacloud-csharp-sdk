// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreatePluginResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f3bde29b43d4d53989248327ff737f2</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF924FE4-2EDD-4CD3-89EC-34E4708574E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the plug-in is successfully marked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TagStatus")]
        [Validation(Required=false)]
        public bool? TagStatus { get; set; }

    }

}
