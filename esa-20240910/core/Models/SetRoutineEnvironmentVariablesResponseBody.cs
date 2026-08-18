// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetRoutineEnvironmentVariablesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of environment variable keys that were set successfully.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;key1&quot;,&quot;key2&quot;]</para>
        /// </summary>
        [NameInMap("SetKeys")]
        [Validation(Required=false)]
        public List<string> SetKeys { get; set; }

    }

}
