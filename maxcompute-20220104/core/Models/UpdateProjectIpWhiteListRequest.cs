// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateProjectIpWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ipWhiteList&quot;:{&quot;ipList&quot;: &quot;&quot;, //string, separate multiple values with commas
        ///                 &quot;vpcIpList&quot;: &quot;&quot;}}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
