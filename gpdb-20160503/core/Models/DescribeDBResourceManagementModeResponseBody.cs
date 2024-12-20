// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBResourceManagementModeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource management mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>resourceGroup: resource group management.</description></item>
        /// <item><description>resourceQueue: resource queue management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>resourceGroup</para>
        /// </summary>
        [NameInMap("ResourceManagementMode")]
        [Validation(Required=false)]
        public string ResourceManagementMode { get; set; }

    }

}
