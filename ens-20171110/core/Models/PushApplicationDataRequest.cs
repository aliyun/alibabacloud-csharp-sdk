// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e76f8985-7965-41fc-925b-9648bb6bf650</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The data files that you want to push. The value must be a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;app01\&quot;,       \&quot;version\&quot;:\&quot;1.0\&quot;,       \&quot;size\&quot;:100,\&quot;archiveType\&quot;:\&quot;tar.gz\&quot;,       \&quot;md5\&quot;:\&quot;\&quot;,       \&quot;url\&quot;:\&quot;<a href="http://xxxx%5C%5C%22,%5C%5C%22timeout%5C%5C">http://xxxx\\&quot;,\\&quot;timeout\\</a>&quot;: 1000   },    {       \&quot;name\&quot;:\&quot;app02\&quot;,       \&quot;version\&quot;:\&quot;1.1\&quot;,       \&quot;size\&quot;:10,\&quot;archiveType\&quot;:\&quot;zip\&quot;,       \&quot;md5\&quot;:\&quot;xxxx\&quot;,       \&quot;url\&quot;:\&quot;<a href="http://xxxxxx%5C%5C%22,%5C%5C%22timeout%5C%5C">http://xxxxxx\\&quot;,\\&quot;timeout\\</a>&quot;: 1000   }]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The push policy in the canary release environment. The value must be a JSON string. You can specify multiple push policies. By default, all data files are pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;name\&quot;: \&quot;ScheduleToRegionId\&quot;,  \&quot;parameters\&quot;:{      \&quot;operator\&quot;: \&quot;In\&quot;,       \&quot;values\&quot;: [\&quot;cn-chegndu-telecom-4\&quot;, \&quot;cn-shanghai-cmcc-4\&quot;]  }}</para>
        /// </summary>
        [NameInMap("PushStrategy")]
        [Validation(Required=false)]
        public string PushStrategy { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
