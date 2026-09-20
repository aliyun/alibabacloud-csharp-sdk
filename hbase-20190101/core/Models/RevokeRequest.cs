// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class RevokeRequest : TeaModel {
        /// <summary>
        /// <para>The database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The list of permissions. Separate multiple permissions with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>READ: read permission.</description></item>
        /// <item><description>WRITE: write permission.</description></item>
        /// <item><description>ADMIN: administrative permission.</description></item>
        /// <item><description>TRASH: purge permission.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READ,WRITE</para>
        /// </summary>
        [NameInMap("AclActions")]
        [Validation(Required=false)]
        public string AclActions { get; set; }

        /// <summary>
        /// <para>The target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The namespace. An asterisk (*) indicates global, which means all namespaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The table name. An asterisk (*) indicates global, which means all tables.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
