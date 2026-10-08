// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreatePostgresExtensionsRequest : TeaModel {
        /// <summary>
        /// <para>The user to which the extension belongs. Only privileged accounts are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-gc7f1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name of the instance. You can call DescribeDatabases to query the database name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("DBNames")]
        [Validation(Required=false)]
        public string DBNames { get; set; }

        /// <summary>
        /// <para>The plugins to install. Separate multiple plugins with commas (,).
        /// If you do not specify the request parameter <b>SourceDatabase</b>, this parameter is required.</para>
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
        /// <para>The resource group ID.</para>
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
        /// <para>Specifies whether to confirm the security risk of installing specific extensions on instances that run minor engine versions that are too early. After you confirm the risk, the extensions can be installed.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false<remarks>
        /// <para>For information about related risks, see <a href="https://help.aliyun.com/document_detail/2587815.html">Restrictions on creating extensions in ApsaraDB RDS for PostgreSQL</a>.</para>
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
        /// <para>The source database from which plugins are synchronized to the target database. If you do not specify the request parameter <b>Extensions</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source_db</para>
        /// </summary>
        [NameInMap("SourceDatabase")]
        [Validation(Required=false)]
        public string SourceDatabase { get; set; }

    }

}
