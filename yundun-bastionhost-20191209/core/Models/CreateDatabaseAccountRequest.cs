// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateDatabaseAccountRequest : TeaModel {
        /// <summary>
        /// <para>The username of the database account to be created. The username can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("DatabaseAccountName")]
        [Validation(Required=false)]
        public string DatabaseAccountName { get; set; }

        /// <summary>
        /// <para>The ID of the database for which you want to create a database account.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2758839.html">ListDatabaseAccounts</a> operation to query the database account ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// <para>The name of the database. This parameter is required for PostgreSQL and Oracle databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orcl</para>
        /// </summary>
        [NameInMap("DatabaseSchema")]
        [Validation(Required=false)]
        public string DatabaseSchema { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host for which you want to create a database account.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-5yd34ol020a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The logon attribute. This parameter is required for Oracle databases. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SERVICENAME</description></item>
        /// <item><description>SID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SID</para>
        /// </summary>
        [NameInMap("LoginAttribute")]
        [Validation(Required=false)]
        public string LoginAttribute { get; set; }

        /// <summary>
        /// <para>The password of the database account to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCQ******</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host for which you want to create a database account.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
