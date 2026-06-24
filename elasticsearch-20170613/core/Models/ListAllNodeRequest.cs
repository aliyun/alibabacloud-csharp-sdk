// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAllNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return monitoring information for the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Returns monitoring information.</para>
        /// </description></item>
        /// <item><description><para>false: Does not return monitoring information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("extended")]
        [Validation(Required=false)]
        public bool? Extended { get; set; }

    }

}
