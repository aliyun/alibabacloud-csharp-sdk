// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetEtlMetaRequest : TeaModel {
        [NameInMap("elMetaName")]
        [Validation(Required=false)]
        public string ElMetaName { get; set; }

        [NameInMap("etlMetaKey")]
        [Validation(Required=false)]
        public string EtlMetaKey { get; set; }

        /// <summary>
        /// 此处固定为 "__all_etl_meta_tag_match__"。
        /// </summary>
        [NameInMap("etlMetaTag")]
        [Validation(Required=false)]
        public string EtlMetaTag { get; set; }

    }

}
