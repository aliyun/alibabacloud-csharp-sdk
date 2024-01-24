// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetupRecycleBinStatusRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the status of the table recycle bin. Valid values:
        /// 
        /// *   enable: The table recycle bin is enabled.
        /// *   disable: The table recycle bin is disabled.
        /// </summary>
        [NameInMap("StatusAction")]
        [Validation(Required=false)]
        public string StatusAction { get; set; }

    }

}
