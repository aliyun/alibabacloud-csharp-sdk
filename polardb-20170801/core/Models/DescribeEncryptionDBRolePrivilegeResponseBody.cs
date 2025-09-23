// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeEncryptionDBRolePrivilegeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEncryptionDBRolePrivilegeResponseBodyData Data { get; set; }
        public class DescribeEncryptionDBRolePrivilegeResponseBodyData : TeaModel {
            [NameInMap("RolePrivilegeList")]
            [Validation(Required=false)]
            public List<DescribeEncryptionDBRolePrivilegeResponseBodyDataRolePrivilegeList> RolePrivilegeList { get; set; }
            public class DescribeEncryptionDBRolePrivilegeResponseBodyDataRolePrivilegeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[alton01]</para>
                /// </summary>
                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Negation")]
                [Validation(Required=false)]
                public string Negation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[alton]</para>
                /// </summary>
                [NameInMap("NotEncryption")]
                [Validation(Required=false)]
                public string NotEncryption { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RolePrivilegeName")]
                [Validation(Required=false)]
                public string RolePrivilegeName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD86******</para>
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
