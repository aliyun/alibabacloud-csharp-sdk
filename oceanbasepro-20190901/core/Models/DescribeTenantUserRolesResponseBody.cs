// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantUserRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of roles of the user.<br>Valid values: </para>
        /// <para>ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES.
        /// ReadOnly: a role that has only the read-only privilege SELECT.
        /// DDL: a role that has DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW.
        /// DML: a role that has DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public List<string> Role { get; set; }

    }

}
