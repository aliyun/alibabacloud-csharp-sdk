// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCollationTimeZoneRequest : TeaModel {
        /// <summary>
        /// The character set collation of the instance. Valid values:
        /// 
        /// *   **Latin1\_General_CI_AS**
        /// *   **Latin1\_General_CS_AS**
        /// *   **SQL_Latin1\_General_CP1\_CI_AS**
        /// *   **SQL_Latin1\_General_CP1\_CS_AS**
        /// *   **Chinese_PRC_CS_AS**
        /// *   **Chinese_PRC_BIN**
        /// *   **Chinese_PRC_CI_AS**
        /// *   **Japanese_CI_AS**
        /// *   **Japanese_CS_AS**
        /// *   **Chinese_Taiwan_Stroke_CI_AS**
        /// *   **Chinese_Taiwan_Stroke_CS_AS**
        /// 
        /// By default, the system does not modify the character set collation of the instance.
        /// 
        /// > You must specify one of the **Collation** and **Timezone** parameters.
        /// </summary>
        [NameInMap("Collation")]
        [Validation(Required=false)]
        public string Collation { get; set; }

        /// <summary>
        /// The instance ID.
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
        /// > You must specify one of the **Collation** and **Timezone** parameters.
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
