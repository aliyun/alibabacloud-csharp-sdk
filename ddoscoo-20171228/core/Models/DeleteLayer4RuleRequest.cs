// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DeleteLayer4RuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InstanceId&quot;:&quot;0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc&quot;,&quot;Protocol&quot;:&quot;tcp&quot;,&quot;FrontendPort&quot;:80}</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
