// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRequest : TeaModel {
        [NameInMap("MemberToUpdate")]
        [Validation(Required=false)]
        public string MemberToUpdate { get; set; }

        /// <summary>
        /// <para>The type of the service update. Valid values: merge and replace. By default, merge is used if you do not specify this parameter.</para>
        /// <list type="bullet">
        /// <item><description>merge: If the JSON string configured for the existing service is <c>{&quot;a&quot;:&quot;b&quot;}</c> and the JSON string specified in the body parameter is <c>{&quot;c&quot;:&quot;d&quot;}</c>, the JSON string is <c>{&quot;a&quot;:&quot;b&quot;,&quot;c&quot;:&quot;d&quot;}</c> after the service update.</description></item>
        /// <item><description>replace: If the JSON string configured for the existing service is <c>{&quot;a&quot;:&quot;b&quot;}</c> and the JSON string specified in the body parameter is <c>{&quot;c&quot;:&quot;d&quot;}</c>, the JSON string is <c>{&quot;c&quot;:&quot;d&quot;}</c> after the service update.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>merge</para>
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

        /// <summary>
        /// <para>The request body. The body includes the request parameters that you want to update. For more information about the request parameters, see <a href="https://help.aliyun.com/document_detail/412086.html">CreateService</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;name&quot;: &quot;foo&quot;,   &quot;model_path&quot;: &quot;<a href="http://path/to/model.tar.gz">http://path/to/model.tar.gz</a>&quot;,   &quot;processor&quot;: &quot;tensorflow_cpu&quot;,   &quot;metadata&quot;: {     &quot;instance&quot;: 2,     &quot;memory&quot;: 7000,     &quot;cpu&quot;: 4   } }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
