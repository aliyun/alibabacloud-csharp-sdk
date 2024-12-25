// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeListenerAccessControlAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the whitelist is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open_white_list</b>: the whitelist is enabled.</description></item>
        /// <item><description><b>close</b>: the whitelist is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open_white_list</para>
        /// </summary>
        [NameInMap("AccessControlStatus")]
        [Validation(Required=false)]
        public string AccessControlStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried ACLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceItems")]
        [Validation(Required=false)]
        public string SourceItems { get; set; }

    }

}
