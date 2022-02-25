// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateJenkinsImageRegistryPersistenceDayRequest : TeaModel {
        /// <summary>
        /// 保留周期
        /// </summary>
        [NameInMap("PersistenceDay")]
        [Validation(Required=false)]
        public int? PersistenceDay { get; set; }

        /// <summary>
        /// 镜像仓id
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
