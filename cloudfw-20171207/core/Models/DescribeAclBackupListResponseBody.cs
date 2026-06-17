// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclBackupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup records.</para>
        /// </summary>
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public List<DescribeAclBackupListResponseBodyBackups> Backups { get; set; }
        public class DescribeAclBackupListResponseBodyBackups : TeaModel {
            /// <summary>
            /// <para>The number of access control policies in the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AclCount")]
            [Validation(Required=false)]
            public int? AclCount { get; set; }

            /// <summary>
            /// <para>The time when the backup was created. This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743683400</para>
            /// </summary>
            [NameInMap("BackUpTime")]
            [Validation(Required=false)]
            public long? BackUpTime { get; set; }

            /// <summary>
            /// <para>The description of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C9105F2-9F31-5A62-8D52-FA65A3E5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
