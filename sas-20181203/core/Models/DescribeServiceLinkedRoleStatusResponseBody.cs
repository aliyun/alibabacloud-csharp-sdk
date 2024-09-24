// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeServiceLinkedRoleStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39CE98F4-88C0-4539-B906-6B542E5C07B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status information about the service-linked role.</para>
        /// </summary>
        [NameInMap("RoleStatus")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusResponseBodyRoleStatus RoleStatus { get; set; }
        public class DescribeServiceLinkedRoleStatusResponseBodyRoleStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service-linked role is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
