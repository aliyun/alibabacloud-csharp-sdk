// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            [NameInMap("Flv")]
            [Validation(Required=false)]
            public string Flv { get; set; }

            [NameInMap("HlsM3u8")]
            [Validation(Required=false)]
            public string HlsM3u8 { get; set; }

            [NameInMap("HlsTs")]
            [Validation(Required=false)]
            public string HlsTs { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public long? Interval { get; set; }

            [NameInMap("JpgOnDemand")]
            [Validation(Required=false)]
            public string JpgOnDemand { get; set; }

            [NameInMap("JpgOverwrite")]
            [Validation(Required=false)]
            public string JpgOverwrite { get; set; }

            [NameInMap("JpgSequence")]
            [Validation(Required=false)]
            public string JpgSequence { get; set; }

            [NameInMap("Mp4")]
            [Validation(Required=false)]
            public string Mp4 { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            [NameInMap("OssFilePrefix")]
            [Validation(Required=false)]
            public string OssFilePrefix { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            [NameInMap("TransConfigs")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyTemplatesTransConfigs> TransConfigs { get; set; }
            public class DescribeTemplatesResponseBodyTemplatesTransConfigs : TeaModel {
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public long? Fps { get; set; }

                [NameInMap("Gop")]
                [Validation(Required=false)]
                public long? Gop { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("VideoBitrate")]
                [Validation(Required=false)]
                public long? VideoBitrate { get; set; }

                [NameInMap("VideoCodec")]
                [Validation(Required=false)]
                public string VideoCodec { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
