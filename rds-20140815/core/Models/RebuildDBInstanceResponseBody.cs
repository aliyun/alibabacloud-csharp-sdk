// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RebuildDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The serial number of the task in the rebuild task queue. When the serial number becomes 0, the system starts to rebuild the secondary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>329****</para>
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public int? MigrationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>355DA57C-8CC4-40AB-B3F8-B684BA32EB9E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20867****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
