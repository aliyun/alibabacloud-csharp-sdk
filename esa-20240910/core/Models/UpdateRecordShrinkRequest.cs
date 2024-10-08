// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordShrinkRequest : TeaModel {
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public string AuthConfShrink { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string DataShrink { get; set; }

        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        /// <summary>
        /// <para>是否代理加速</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
