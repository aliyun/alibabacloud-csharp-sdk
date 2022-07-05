// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EtlMeta : TeaModel {
        /// <summary>
        /// 是否启用
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// key
        /// </summary>
        [NameInMap("etlMetaKey")]
        [Validation(Required=false)]
        public string EtlMetaKey { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [NameInMap("etlMetaName")]
        [Validation(Required=false)]
        public string EtlMetaName { get; set; }

        /// <summary>
        /// tag
        /// </summary>
        [NameInMap("etlMetaTag")]
        [Validation(Required=false)]
        public string EtlMetaTag { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [NameInMap("etlMetaValue")]
        [Validation(Required=false)]
        public Dictionary<string, string> EtlMetaValue { get; set; }

    }

}
