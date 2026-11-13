// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreatePostgresExtensionsRequest : TeaModel {
        /// <summary>
        /// <para>The user to which the extensions belong. Only privileged accounts are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the DescribeDBInstances operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-gc7f1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database in the instance. You can call the DescribeDatabases operation to obtain the database name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("DBNames")]
        [Validation(Required=false)]
        public string DBNames { get; set; }

        /// <summary>
        /// <para>The extensions to be installed. Separate multiple extensions with commas (,).
        /// If you do not specify the <b>SourceDatabase</b> request parameter, you must specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>citext,pg_profile</para>
        /// </summary>
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether security risk of installing specific extensions on instances with outdated minor engine versions is confirmed. You can install the extensions only after you confirm security risk.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false<remarks>
        /// <para>For more information about security risk description, see <a href="https://help.aliyun.com/document_detail/2587815.html">Restrictions on creating extensions in ApsaraDB RDS for PostgreSQL</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RiskConfirmed")]
        [Validation(Required=false)]
        public bool? RiskConfirmed { get; set; }

        /// <summary>
        /// <para>The source database from which extensions are synchronized to the destination database. If you do not specify the <b>Extensions</b> request parameter, you must specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source_db</para>
        /// </summary>
        [NameInMap("SourceDatabase")]
        [Validation(Required=false)]
        public string SourceDatabase { get; set; }

    }

}
