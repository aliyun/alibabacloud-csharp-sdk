// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;name&quot;:&quot;project_name&quot;,
        ///     &quot;comment&quot;:&quot;&quot;,
        ///     &quot;productType&quot;:&quot;payasyougo/subscription/dev&quot;,
        ///     &quot;defaultQuota&quot;:&quot;quota_nick_name&quot;,
        ///     &quot;properties&quot;:{
        ///         &quot;sqlMeteringMax&quot;:&quot;&quot;,
        ///         &quot;typeSystem&quot;:&quot;&quot;,
        ///         &quot;encryption&quot;:{
        ///             &quot;enable&quot;:true,
        ///             &quot;algorithm&quot;:&quot;&quot;,
        ///             &quot;key&quot;:&quot;&quot;
        ///         }
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
