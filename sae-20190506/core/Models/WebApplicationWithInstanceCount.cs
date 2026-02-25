// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplicationWithInstanceCount : TeaModel {
        /// <summary>
        /// <para>The number of application instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("WebApplication")]
        [Validation(Required=false)]
        public WebApplication WebApplication { get; set; }

    }

}
