// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclChecksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ACL check records.</para>
        /// </summary>
        [NameInMap("CheckRecords")]
        [Validation(Required=false)]
        public DescribeAclChecksResponseBodyCheckRecords CheckRecords { get; set; }
        public class DescribeAclChecksResponseBodyCheckRecords : TeaModel {
            /// <summary>
            /// <para>The type of ACL check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            /// <summary>
            /// <para>The list of ACL check records.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<DescribeAclChecksResponseBodyCheckRecordsRecords> Records { get; set; }
            public class DescribeAclChecksResponseBodyCheckRecordsRecords : TeaModel {
                /// <summary>
                /// <para>The number of pending ACL check tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AclPendingCount")]
                [Validation(Required=false)]
                public long? AclPendingCount { get; set; }

                /// <summary>
                /// <para>The total number of ACL checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AclTotalCount")]
                [Validation(Required=false)]
                public long? AclTotalCount { get; set; }

                /// <summary>
                /// <para>The name of the ACL check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AddressBookDomainValid</para>
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <para>The status of the ACL check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Checked</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// <para>The type of ACL check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AddressBookGather</para>
                /// </summary>
                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp of the last check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724982259</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public string LastCheckTime { get; set; }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Medium</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The ID of the ACL check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-c92d4544ef7b6a42</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AABB1B7-C81F-5158-9EF9-B2DD5D3D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
