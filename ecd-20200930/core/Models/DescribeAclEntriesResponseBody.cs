// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeAclEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL entries.</para>
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<DescribeAclEntriesResponseBodyAclEntries> AclEntries { get; set; }
        public class DescribeAclEntriesResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// <para>The ACL type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>allow: whitelist</description></item>
            /// <item><description>disable: blacklist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the ACL applies. You can specify an office network ID or a cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-fsafeweh***</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The granularity of the ACL.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>desktop: cloud computer</description></item>
            /// <item><description>vpc: office network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>desktop</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The token that is used to start the next query. If the value of this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
