// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ReinstallCollectorRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters. For more information, see the Request body section in this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Indicates whether the shipper is installed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The shipper is installed.</description></item>
        /// <item><description>false: The shipper fails to be installed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;restartType&quot;: &quot;nodeEcsId&quot;,
        ///   &quot;nodes&quot;:[&quot;i-bp1gyhphjaj73jsr****&quot;,&quot;i-bp10piq1mkfnyw9t****&quot;]
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
