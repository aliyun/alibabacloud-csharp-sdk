// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The database names, in the format of &quot;db1,db2&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db1,db2</para>
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08A3B71B-FE08-xxxx-974F-CC7EA6DBxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
