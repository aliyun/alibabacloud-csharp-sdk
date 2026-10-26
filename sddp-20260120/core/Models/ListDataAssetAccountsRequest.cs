// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataAssetAccountsRequest : TeaModel {
        /// <summary>
        /// <para>The database account name. The system filters accounts by the exact account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_reader</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The authentication database of the MongoDB account. This parameter is used to distinguish accounts with the same name in different authentication databases.</para>
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
        /// <item><description>fullAccess: plaintext access</description></item>
        /// <item><description>restrictedAccess: restricted access</description></item>
        /// <item><description>noneAccess: decryption prohibited. This value applies only to ApsaraDB RDS for MySQL instances whose current effective key mode is client_key.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fullAccess</para>
        /// </summary>
        [NameInMap("AuthRole")]
        [Validation(Required=false)]
        public string AuthRole { get; set; }

        /// <summary>
        /// <para>The business scenario for the query. Set this parameter to DataMasking for the column encryption scenario. Note that the value is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataMasking</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The page number of the current page. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The database instance ID. You can obtain this value from the Items[].InstanceId parameter in the response of the ListDataMaskingInstances operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Keep other filter conditions consistent when querying the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The list of cloud service type IDs. Separate multiple values with commas (,). For the column encryption scenario, the valid values are 5 (RDS), 8 (POLARDB), and 27 (PolarDBX2).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

    }

}
