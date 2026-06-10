// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CheckInstanceSupportRequest : TeaModel {
        /// <summary>
        /// <para>List of instance IDs to check</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-2zxxxxxx&quot;]</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Region to which the instances belong. Ensure that all instance IDs passed in the instances list belong to the same region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
