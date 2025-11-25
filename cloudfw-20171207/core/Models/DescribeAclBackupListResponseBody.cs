// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclBackupListResponseBody : TeaModel {
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public List<DescribeAclBackupListResponseBodyBackups> Backups { get; set; }
        public class DescribeAclBackupListResponseBodyBackups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AclCount")]
            [Validation(Required=false)]
            public int? AclCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1743683400</para>
            /// </summary>
            [NameInMap("BackUpTime")]
            [Validation(Required=false)]
            public long? BackUpTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6C9105F2-9F31-5A62-8D52-FA65A3E5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
