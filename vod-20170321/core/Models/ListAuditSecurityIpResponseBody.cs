// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAuditSecurityIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>664BBD08-C7DB-4E*****73-9D0958D9A899</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the review security group.</para>
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public List<ListAuditSecurityIpResponseBodySecurityIpList> SecurityIpList { get; set; }
        public class ListAuditSecurityIpResponseBodySecurityIpList : TeaModel {
            /// <summary>
            /// <para>The time when the review security group was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-22T06:54:23Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The IP addresses in the review security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.27.14.0/24,30.39.127.245</para>
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public string Ips { get; set; }

            /// <summary>
            /// <para>The time when the review security group was last modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-22T06:55:14Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The name of the review security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

    }

}
