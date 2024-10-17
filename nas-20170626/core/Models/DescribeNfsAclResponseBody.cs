// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeNfsAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ACL feature.</para>
        /// </summary>
        [NameInMap("Acl")]
        [Validation(Required=false)]
        public DescribeNfsAclResponseBodyAcl Acl { get; set; }
        public class DescribeNfsAclResponseBodyAcl : TeaModel {
            /// <summary>
            /// <para>Indicates whether the NFS ACL feature is enabled.</para>
            /// <list type="bullet">
            /// <item><description>true: The NFS ACL feature is enabled.</description></item>
            /// <item><description>false: The NFS ACL feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1098673-1746-505E-A5F1-08527B7EDBDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
