// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to trace the API call link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withStatistics")]
        [Validation(Required=false)]
        public bool? WithStatistics { get; set; }

        /// <summary>
        /// <para>Schema of Response</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withVpcInfo")]
        [Validation(Required=false)]
        public bool? WithVpcInfo { get; set; }

    }

}
