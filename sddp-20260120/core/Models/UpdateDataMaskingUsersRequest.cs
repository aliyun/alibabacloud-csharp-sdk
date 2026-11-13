// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpdateDataMaskingUsersRequest : TeaModel {
        /// <summary>
        /// <para>The column encryption access permissions. Valid values: fullAccess: Allows plaintext access. restrictedAccess: Allows restricted access. noneAccess: Prohibits decryption. noneAccess applies only to ApsaraDB RDS for MySQL instances whose active key pattern is client_key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullAccess</para>
        /// </summary>
        [NameInMap("AuthRole")]
        [Validation(Required=false)]
        public string AuthRole { get; set; }

        /// <summary>
        /// <para>The expiration time of the plaintext access permissions. The value is a UNIX timestamp in milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970. Specify this parameter only when ExpireTimeOperation is set to SET. The value must be later than the current time and no greater than 2145953410000. The server saves the value with second-level precision. Do not specify this parameter when ExpireTimeOperation is set to PRESERVE or CLEAR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2145953410000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The processing method for the permission expiration time. Valid values: PRESERVE: retains the original expiration time. CLEAR: clears the expiration time. SET: sets ExpireTime. Default value: PRESERVE. Only fullAccess supports setting an expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRESERVE</para>
        /// </summary>
        [NameInMap("ExpireTimeOperation")]
        [Validation(Required=false)]
        public string ExpireTimeOperation { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values: zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The cloud service code. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also specified, the two parameters must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The cloud service type identifier. Valid values: 5: RDS, 8: POLARDB, and 27: PolarDBX2. If both ProductId and ProductCode are specified, they must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The list of database accounts for which you want to configure permissions.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<UpdateDataMaskingUsersRequestUserList> UserList { get; set; }
        public class UpdateDataMaskingUsersRequestUserList : TeaModel {
            /// <summary>
            /// <para>The name of the database account. Obtain the value from Items[].AccountName in the response of ListDataAssetAccounts and pass it as a string without modification. Do not pass Items[].Id. Each AccountId must correspond to the InstanceId in the same item. Accounts with the same name in different instances are considered different targets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_reader</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The authentication database of MongoDB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("AuthDb")]
            [Validation(Required=false)]
            public string AuthDb { get; set; }

            /// <summary>
            /// <para>The database instance identity. You can obtain the value from Items[].InstanceId in the response of ListDataMaskingInstances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1abcdefgh****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
