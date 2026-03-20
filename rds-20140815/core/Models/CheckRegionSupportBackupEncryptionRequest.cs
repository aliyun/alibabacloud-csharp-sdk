// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckRegionSupportBackupEncryptionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-wz91q53f9*******</para>
        /// </summary>
        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public string DBInstanceID { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
