// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("CasterName")]
        [Validation(Required=true)]
        public string CasterName { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("Delay")]
        [Validation(Required=true)]
        public float? Delay { get; set; }

        [NameInMap("UrgentMaterialId")]
        [Validation(Required=true)]
        public string UrgentMaterialId { get; set; }

        [NameInMap("SideOutputUrl")]
        [Validation(Required=true)]
        public string SideOutputUrl { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=true)]
        public string CallbackUrl { get; set; }

        [NameInMap("ProgramName")]
        [Validation(Required=true)]
        public string ProgramName { get; set; }

        [NameInMap("ProgramEffect")]
        [Validation(Required=true)]
        public int? ProgramEffect { get; set; }

        [NameInMap("ChannelEnable")]
        [Validation(Required=true)]
        public int? ChannelEnable { get; set; }

        [NameInMap("TranscodeConfig")]
        [Validation(Required=true)]
        public DescribeCasterConfigResponseTranscodeConfig TranscodeConfig { get; set; }
        public class DescribeCasterConfigResponseTranscodeConfig : TeaModel {
            [NameInMap("CasterTemplate")]
            [Validation(Required=true)]
            public string CasterTemplate { get; set; }
            [NameInMap("LiveTemplateIds")]
            [Validation(Required=true)]
            public DescribeCasterConfigResponseTranscodeConfigLiveTemplateIds LiveTemplateIds { get; set; }
            public class DescribeCasterConfigResponseTranscodeConfigLiveTemplateIds : TeaModel {
                /// <summary>
                /// LocationId
                /// </summary>
                [NameInMap("LocationId")]
                [Validation(Required=true)]
                public List<string> LocationId { get; set; }

            }
        };

        [NameInMap("RecordConfig")]
        [Validation(Required=true)]
        public DescribeCasterConfigResponseRecordConfig RecordConfig { get; set; }
        public class DescribeCasterConfigResponseRecordConfig : TeaModel {
            [NameInMap("OssEndpoint")]
            [Validation(Required=true)]
            public string OssEndpoint { get; set; }
            [NameInMap("OssBucket")]
            [Validation(Required=true)]
            public string OssBucket { get; set; }
            [NameInMap("RecordFormat")]
            [Validation(Required=true)]
            public DescribeCasterConfigResponseRecordConfigRecordFormat RecordFormat { get; set; }
            public class DescribeCasterConfigResponseRecordConfigRecordFormat : TeaModel {
                [NameInMap("RecordFormat")]
                [Validation(Required=true)]
                public List<DescribeCasterConfigResponseRecordConfigRecordFormatRecordFormat> RecordFormat { get; set; }
                public class DescribeCasterConfigResponseRecordConfigRecordFormatRecordFormat : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=true)]
                    public string Format { get; set; }

                    [NameInMap("OssObjectPrefix")]
                    [Validation(Required=true)]
                    public string OssObjectPrefix { get; set; }

                    [NameInMap("SliceOssObjectPrefix")]
                    [Validation(Required=true)]
                    public string SliceOssObjectPrefix { get; set; }

                    [NameInMap("CycleDuration")]
                    [Validation(Required=true)]
                    public int? CycleDuration { get; set; }

                }

            }
        };

    }

}
