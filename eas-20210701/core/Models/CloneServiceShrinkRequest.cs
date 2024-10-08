// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CloneServiceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The label of the service to be cloned.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// <para>The request body. For more information, see <a href="https://help.aliyun.com/document_detail/412086.html">CreateService</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;name&quot;: &quot;foo&quot;,   &quot;model_path&quot;: &quot;<a href="http://path/to/model.tar.gz">http://path/to/model.tar.gz</a>&quot;,   &quot;processor&quot;: &quot;tensorflow_cpu&quot;,   &quot;metadata&quot;: {     &quot;instance&quot;: 2,     &quot;memory&quot;: 7000,     &quot;cpu&quot;: 4   } }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
