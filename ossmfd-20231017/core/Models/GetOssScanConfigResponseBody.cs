// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssMfd20231017.Models
{
    public class GetOssScanConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssScanConfigResponseBodyData Data { get; set; }
        public class GetOssScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllKeyPrefix")]
            [Validation(Required=false)]
            public bool? AllKeyPrefix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testBucket******</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DecompressMaxFileCount")]
            [Validation(Required=false)]
            public int? DecompressMaxFileCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DecompressMaxLayer")]
            [Validation(Required=false)]
            public int? DecompressMaxLayer { get; set; }

            [NameInMap("DecryptionList")]
            [Validation(Required=false)]
            public List<string> DecryptionList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13******</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("KeyPrefixList")]
            [Validation(Required=false)]
            public List<string> KeyPrefixList { get; set; }

            [NameInMap("KeySuffixList")]
            [Validation(Required=false)]
            public List<string> KeySuffixList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1702025633079</para>
            /// </summary>
            [NameInMap("LastModifiedStartTime")]
            [Validation(Required=false)]
            public long? LastModifiedStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1702025633079</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testPolicy******</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RealTimeIncr")]
            [Validation(Required=false)]
            public bool? RealTimeIncr { get; set; }

            [NameInMap("ScanDayList")]
            [Validation(Required=false)]
            public List<int?> ScanDayList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E14CECBF-8CAC-520C-ACC3-9503D5******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
