// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DEA36EF-C97D-5658-A4AC-4F5DB08D1A89</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;LogicalResourceIdPattern\&quot;: \&quot;wait1\&quot;, \&quot;ResourceType\&quot;: \&quot;time_sleep\&quot;, \&quot;ResourcePath\&quot;: \&quot;wait1\&quot;}, {\&quot;LogicalResourceIdPattern\&quot;: \&quot;wait2\&quot;, \&quot;ResourceType\&quot;: \&quot;time_sleep\&quot;, \&quot;ResourcePath\&quot;: \&quot;wait2\&quot;}]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public Dictionary<string, object> Resources { get; set; }

    }

}
