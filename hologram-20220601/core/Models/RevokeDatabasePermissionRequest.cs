// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class RevokeDatabasePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The list of permissions.</para>
        /// </summary>
        [NameInMap("privileges")]
        [Validation(Required=false)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// <para>The user ID. For more information, see <a href="https://help.aliyun.com/document_detail/130393.html">Hologres account overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p4_1234xxxx</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
