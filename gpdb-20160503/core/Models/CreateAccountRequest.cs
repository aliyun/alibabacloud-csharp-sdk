// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the initial account. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must start with a Chinese or English letter.</description></item>
        /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It can contain Chinese characters, English letters, underscores (_), hyphens (-), and digits.</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testacc02</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the initial account. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain only lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>It must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>It cannot start with gp.</description></item>
        /// <item><description>It must be 2 to 16 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testacc02</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the initial account.</para>
        /// <list type="bullet">
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Supported special characters: <c>!@#$%^&amp;*()_+-=</c></description></item>
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pw123456</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The account type. Default value: Super, which creates a privileged account. If you set this parameter to Normal, a standard account is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Super</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain only letters, digits, and underscores (_).</description></item>
        /// <item><description>It must start with a letter.</description></item>
        /// <item><description>It cannot exceed 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
