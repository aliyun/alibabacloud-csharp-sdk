// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the permissions are granted.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The permissions are granted.</para>
        /// </description></item>
        /// <item><description><para>false: The permissions are not granted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F539347-7D9A-51EA-8ABF-5D5507045C5C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
