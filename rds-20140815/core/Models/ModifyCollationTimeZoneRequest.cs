// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCollationTimeZoneRequest : TeaModel {
        /// <summary>
        /// The character set collation of the instance. By default, the system does not modify the character set collation of the instance. Valid values:
        /// 
        /// *   **Chinese_PRC_CI_AS**
        /// *   **Chinese_PRC_CS_AS**
        /// *   **Chinese_PRC_BIN**
        /// *   **Latin1_General_CI_AS**
        /// *   **Latin1_General_CS_AS**
        /// *   **SQL_Latin1_General_CP1_CI_AS**
        /// *   **SQL_Latin1_General_CP1_CS_AS**
        /// *   **Japanese_CI_AS**
        /// *   **Japanese_CS_AS**
        /// *   **Chinese_Taiwan_Stroke_CI_AS**
        /// *   **Chinese_Taiwan_Stroke_CS_AS**
        /// 
        /// > *   The default character set collation of the instance is **Chinese_PRC_CI_AS**.
        /// > *   You must specify one of the **Collation** and **Timezone** parameters.
        /// </summary>
        [NameInMap("Collation")]
        [Validation(Required=false)]
        public string Collation { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The time zone of the instance. By default, the system does not modify the time zone.
        /// 
        /// > *   The default time zone of the instance is **China Standard Time**.
        /// > *   You must specify one of the **Collation** and **Timezone** parameters.
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
