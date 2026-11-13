// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RebuildDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The queue number for the rebuild task. When the number is 0, the rebuild and migration process starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3298015</para>
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public int? MigrationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>355DA57C-8CC4-40AB-B3F8-B684BA32EB9E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>208676661</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
