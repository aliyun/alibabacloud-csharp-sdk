// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSecurityIpsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSecurityIpsResponseBodyData Data { get; set; }
        public class DescribeSecurityIpsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-hzjasd****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("GroupItems")]
            [Validation(Required=false)]
            public List<DescribeSecurityIpsResponseBodyDataGroupItems> GroupItems { get; set; }
            public class DescribeSecurityIpsResponseBodyDataGroupItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>defaultGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1,172.168.0.0</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14036EBE-CF2E-44DB-ACE9-AC6157D3A6FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
