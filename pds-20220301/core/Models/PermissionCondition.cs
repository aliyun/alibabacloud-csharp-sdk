// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class PermissionCondition : TeaModel {
        [NameInMap("bool_equals")]
        [Validation(Required=false)]
        public PermissionConditionBoolEquals BoolEquals { get; set; }
        public class PermissionConditionBoolEquals : TeaModel {
            [NameInMap("is_share_link")]
            [Validation(Required=false)]
            public bool? IsShareLink { get; set; }

        }

        [NameInMap("bool_not_equals")]
        [Validation(Required=false)]
        public PermissionConditionBoolNotEquals BoolNotEquals { get; set; }
        public class PermissionConditionBoolNotEquals : TeaModel {
            [NameInMap("is_share_link")]
            [Validation(Required=false)]
            public bool? IsShareLink { get; set; }

        }

        /// <summary>
        /// <para>The IP address condition, which is true when the IP address is equal to one of the following lists.</para>
        /// </summary>
        [NameInMap("ip_equals")]
        [Validation(Required=false)]
        public PermissionConditionIpEquals IpEquals { get; set; }
        public class PermissionConditionIpEquals : TeaModel {
            /// <summary>
            /// <para>The IP address of the client.</para>
            /// </summary>
            [NameInMap("client_ip")]
            [Validation(Required=false)]
            public List<string> ClientIp { get; set; }

        }

        /// <summary>
        /// <para>The IP address condition. This condition is true when the IP address is not equal to any of the following list.</para>
        /// </summary>
        [NameInMap("ip_not_equals")]
        [Validation(Required=false)]
        public PermissionConditionIpNotEquals IpNotEquals { get; set; }
        public class PermissionConditionIpNotEquals : TeaModel {
            /// <summary>
            /// <para>The IP address of the client.</para>
            /// </summary>
            [NameInMap("client_ip")]
            [Validation(Required=false)]
            public List<string> ClientIp { get; set; }

        }

        /// <summary>
        /// <para>The string match condition, which is true when the string is equal to one of the following lists.</para>
        /// </summary>
        [NameInMap("string_like")]
        [Validation(Required=false)]
        public PermissionConditionStringLike StringLike { get; set; }
        public class PermissionConditionStringLike : TeaModel {
            /// <summary>
            /// <para>The vpcID of the client as a string match condition.</para>
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public List<string> VpcId { get; set; }

        }

        /// <summary>
        /// <para>The string match condition. This condition is true when the input string is not equal to any one of the following lists.</para>
        /// </summary>
        [NameInMap("string_not_like")]
        [Validation(Required=false)]
        public PermissionConditionStringNotLike StringNotLike { get; set; }
        public class PermissionConditionStringNotLike : TeaModel {
            /// <summary>
            /// <para>The vpcID of the client as a string match condition.</para>
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public List<string> VpcId { get; set; }

        }

    }

}
