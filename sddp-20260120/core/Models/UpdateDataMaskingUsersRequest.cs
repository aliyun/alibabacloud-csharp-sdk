// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpdateDataMaskingUsersRequest : TeaModel {
        /// <summary>
        /// <para>The column encryption access permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>fullAccess: plaintext access.</description></item>
        /// <item><description>restrictedAccess: restricted access.</description></item>
        /// <item><description>noneAccess: decryption denied.</description></item>
        /// </list>
        /// <para>noneAccess applies only to ApsaraDB RDS for MySQL instances whose active key pattern is client_key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullAccess</para>
        /// </summary>
        [NameInMap("AuthRole")]
        [Validation(Required=false)]
        public string AuthRole { get; set; }

        /// <summary>
        /// <para>The expiration time of the plaintext access permissions. Specify a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC. This parameter is required only when ExpireTimeOperation is set to SET. The value must be later than the current time and no later than 2145953410000. The server stores the value with second-level precision. Do not specify this parameter when ExpireTimeOperation is set to PRESERVE or CLEAR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2145953410000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The action to take on the permission expiration time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRESERVE: Retains the existing expiration time.</description></item>
        /// <item><description>CLEAR: Clears the expiration time.</description></item>
        /// <item><description>SET: Sets the expiration time to the value specified by ExpireTime.</description></item>
        /// </list>
        /// <para>Default value: PRESERVE. Only fullAccess supports configuring a validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRESERVE</para>
        /// </summary>
        [NameInMap("ExpireTimeOperation")]
        [Validation(Required=false)]
        public string ExpireTimeOperation { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The cloud product code. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also specified, the two parameters must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The cloud product type identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: POLARDB.</description></item>
        /// <item><description>27: PolarDBX2.</description></item>
        /// </list>
        /// <para>If both ProductId and ProductCode are specified, they must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The list of database accounts for which to set permissions.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<UpdateDataMaskingUsersRequestUserList> UserList { get; set; }
        public class UpdateDataMaskingUsersRequestUserList : TeaModel {
            /// <summary>
            /// <para>The database account identifier. Obtain this value from Items[].Id in the response of ListDataAssetAccounts and pass it as a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The database instance identity. Obtain this value from Items[].InstanceId in the response of ListDataMaskingInstances.</para>
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
