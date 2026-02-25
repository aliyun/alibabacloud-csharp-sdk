// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplicationStatus : TeaModel {
        /// <summary>
        /// <para>The number of application instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        /// <summary>
        /// <para>The scaling configurations of the application.</para>
        /// </summary>
        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

    }

}
