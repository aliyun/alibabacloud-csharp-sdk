// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataAssetAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of records returned in the current query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListDataAssetAccountsResponseBodyItems> Items { get; set; }
        public class ListDataAssetAccountsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The database account name. When creating a column encryption rule or modifying account permissions, use this field as is for UserList[].AccountId and combine it with the InstanceId of this record to select the target account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_reader</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The authentication database of the MongoDB account. This parameter must be passed together with AccountName when modifying permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("AuthDb")]
            [Validation(Required=false)]
            public string AuthDb { get; set; }

            /// <summary>
            /// <para>The column encryption access permissions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fullAccess: Plaintext access.</description></item>
            /// <item><description>restrictedAccess: Restricted access.</description></item>
            /// <item><description>noneAccess: Decryption prohibited. The noneAccess value applies only to ApsaraDB RDS for MySQL instances whose current effective key pattern is client_key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fullAccess</para>
            /// </summary>
            [NameInMap("AuthRole")]
            [Validation(Required=false)]
            public string AuthRole { get; set; }

            /// <summary>
            /// <para>The current effective column encryption key mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>client_key: Local key.</description></item>
            /// <item><description>kms_key: KMS key.
            /// If no effective configuration exists, this parameter may not be returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>client_key</para>
            /// </summary>
            [NameInMap("EncryptionKeyMode")]
            [Validation(Required=false)]
            public string EncryptionKeyMode { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The expiration time of the plaintext access permissions. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. If the validity period Settings are not configured, this parameter may not be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2145953410000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the Data Security Center (DSC) data asset account record. This is not the database account name. When creating a column encryption rule or modifying account permissions, set AccountId to the AccountName of this record instead of this Id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The database instance identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1abcdefgh****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The cloud service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The cloud service type identifier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>5: RDS.</description></item>
            /// <item><description>8: POLARDB.</description></item>
            /// <item><description>27: PolarDBX2.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The region name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Zhangjiakou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page in the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the current statistics or query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
