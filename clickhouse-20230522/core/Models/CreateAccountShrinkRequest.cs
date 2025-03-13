// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateAccountShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The type of the database account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NormalAccount</b>: standard account</description></item>
        /// <item><description><b>SuperAccount</b>: privileged account</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NormalAccount</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp100p4q1g9z3****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Used for account</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about permissions.</para>
        /// </summary>
        [NameInMap("DmlAuthSetting")]
        [Validation(Required=false)]
        public string DmlAuthSettingShrink { get; set; }

        /// <summary>
        /// <para>The password of the database account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>The following special characters are supported: ! @ # $ % ^ &amp; * ( ) _ + - =</description></item>
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4@</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The code of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
