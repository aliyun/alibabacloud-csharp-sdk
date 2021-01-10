// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterConfigResponseBody : TeaModel {
        [NameInMap("ChannelEnable")]
        [Validation(Required=false)]
        public int? ChannelEnable { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("UrgentMaterialId")]
        [Validation(Required=false)]
        public string UrgentMaterialId { get; set; }

        [NameInMap("TranscodeConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodyTranscodeConfig TranscodeConfig { get; set; }
        public class DescribeCasterConfigResponseBodyTranscodeConfig : TeaModel {
            [NameInMap("CasterTemplate")]
            [Validation(Required=false)]
            public string CasterTemplate { get; set; }
            [NameInMap("LiveTemplateIds")]
            [Validation(Required=false)]
            public DescribeCasterConfigResponseBodyTranscodeConfigLiveTemplateIds LiveTemplateIds { get; set; }
            public class DescribeCasterConfigResponseBodyTranscodeConfigLiveTemplateIds : TeaModel {
                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public List<string> LocationId { get; set; }

            }
        };

        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        [NameInMap("Delay")]
        [Validation(Required=false)]
        public float? Delay { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("RecordConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodyRecordConfig RecordConfig { get; set; }
        public class DescribeCasterConfigResponseBodyRecordConfig : TeaModel {
            [NameInMap("RecordFormat")]
            [Validation(Required=false)]
            public DescribeCasterConfigResponseBodyRecordConfigRecordFormat RecordFormat { get; set; }
            public class DescribeCasterConfigResponseBodyRecordConfigRecordFormat : TeaModel {
                [NameInMap("RecordFormat")]
                [Validation(Required=false)]
                public List<DescribeCasterConfigResponseBodyRecordConfigRecordFormatRecordFormat> RecordFormat { get; set; }
                public class DescribeCasterConfigResponseBodyRecordConfigRecordFormatRecordFormat : TeaModel {
                    [NameInMap("CycleDuration")]
                    [Validation(Required=false)]
                    public int? CycleDuration { get; set; }

                    [NameInMap("SliceOssObjectPrefix")]
                    [Validation(Required=false)]
                    public string SliceOssObjectPrefix { get; set; }

                    [NameInMap("OssObjectPrefix")]
                    [Validation(Required=false)]
                    public string OssObjectPrefix { get; set; }

                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                }

            }
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }
        };

    }

}
