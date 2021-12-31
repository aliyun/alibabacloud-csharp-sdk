// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EncryptUserCmkConf : TeaModel {
        /// <summary>
        /// arn
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// cmk_key_id
        /// </summary>
        [NameInMap("cmk_key_id")]
        [Validation(Required=false)]
        public string CmkKeyId { get; set; }

        /// <summary>
        /// region_id
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
