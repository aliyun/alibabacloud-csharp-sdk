// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordRequest : TeaModel {
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public UpdateRecordRequestAuthConf AuthConf { get; set; }
        public class UpdateRecordRequestAuthConf : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

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
        public UpdateRecordRequestData Data { get; set; }
        public class UpdateRecordRequestData : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

            [NameInMap("MatchingType")]
            [Validation(Required=false)]
            public int? MatchingType { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("Selector")]
            [Validation(Required=false)]
            public int? Selector { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

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
