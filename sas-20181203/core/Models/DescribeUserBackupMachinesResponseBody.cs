// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserBackupMachinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about servers that have backup policies enabled.</para>
        /// </summary>
        [NameInMap("Machines")]
        [Validation(Required=false)]
        public List<DescribeUserBackupMachinesResponseBodyMachines> Machines { get; set; }
        public class DescribeUserBackupMachinesResponseBodyMachines : TeaModel {
            /// <summary>
            /// <para>The ID of the policy enabled on the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the policy enabled on the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy_name_A</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The UUID of the server that has a backup policy enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA0****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA04B21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
