// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The encoding standard of the database.
        /// For more information, see the Charset field returned by the DescribeCharset operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4_general_ci</para>
        /// </summary>
        [NameInMap("Collation")]
        [Validation(Required=false)]
        public string Collation { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud CLI</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sms_pre</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>CreateDatabase</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The collation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.<br>You cannot use reserved keywords, such as test and mysql.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
