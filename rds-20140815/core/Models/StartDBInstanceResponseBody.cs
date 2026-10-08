// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StartDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The migration task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>740</para>
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public int? MigrationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A417FB41-A3D9-464E-AD0A-C7FE05C72E98</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>238028563</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
