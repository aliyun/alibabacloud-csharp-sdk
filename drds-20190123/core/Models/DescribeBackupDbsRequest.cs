// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupDbsRequest : TeaModel {
        /// <summary>
        /// <para>Query by backup set ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>201908367</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The ID of a DRDS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds************</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>Query by restoration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568632541236</para>
        /// </summary>
        [NameInMap("PreferredRestoreTime")]
        [Validation(Required=false)]
        public string PreferredRestoreTime { get; set; }

    }

}
