// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the project and Logstore created by the threat analysis service exist in your Simple Log Service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The project and Logstore exist.</para>
        /// </description></item>
        /// <item><description><para>false: The project and Logstore do not exist.</para>
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
        /// <para>CCEEE128-6607-503E-AAA6-C5E57D94****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
