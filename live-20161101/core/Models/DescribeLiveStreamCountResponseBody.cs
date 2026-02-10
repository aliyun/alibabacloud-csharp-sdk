// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FCFFE4A4-F34F-4EEF-B401-36A01689AFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StreamCountInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamCountResponseBodyStreamCountInfos StreamCountInfos { get; set; }
        public class DescribeLiveStreamCountResponseBodyStreamCountInfos : TeaModel {
            [NameInMap("StreamCountInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfo> StreamCountInfo { get; set; }
            public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfo : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Limit")]
                [Validation(Required=false)]
                public long? Limit { get; set; }

                [NameInMap("StreamCountDetails")]
                [Validation(Required=false)]
                public DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetails StreamCountDetails { get; set; }
                public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetails : TeaModel {
                    [NameInMap("StreamCountDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail> StreamCountDetail { get; set; }
                    public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail : TeaModel {
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("VideoDataRate")]
                        [Validation(Required=false)]
                        public long? VideoDataRate { get; set; }

                    }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
