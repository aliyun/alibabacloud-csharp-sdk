// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribePreCheckProgressListRequest : TeaModel {
        /// <summary>
        /// <para>The backup schedule ID.</para>
        /// <remarks>
        /// <para> You must specify one of BackupPlanId and RestoreTaskId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01XXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The restoration task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbasdsaXXXX</para>
        /// </summary>
        [NameInMap("RestoreTaskId")]
        [Validation(Required=false)]
        public string RestoreTaskId { get; set; }

    }

}
