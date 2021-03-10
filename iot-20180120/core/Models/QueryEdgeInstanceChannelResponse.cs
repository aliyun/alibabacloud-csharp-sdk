// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceChannelResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeInstanceChannelResponseData Data { get; set; }
        public class QueryEdgeInstanceChannelResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("ChannelList")]
            [Validation(Required=true)]
            public QueryEdgeInstanceChannelResponseDataChannelList ChannelList { get; set; }
            public class QueryEdgeInstanceChannelResponseDataChannelList : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=true)]
                public List<QueryEdgeInstanceChannelResponseDataChannelListChannel> Channel { get; set; }
                public class QueryEdgeInstanceChannelResponseDataChannelListChannel : TeaModel {
                    [NameInMap("ChannelId")]
                    [Validation(Required=true)]
                    public string ChannelId { get; set; }

                    [NameInMap("ChannelName")]
                    [Validation(Required=true)]
                    public string ChannelName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtCreateTimestamp")]
                    [Validation(Required=true)]
                    public long? GmtCreateTimestamp { get; set; }

                    [NameInMap("GmtModifiedTimestamp")]
                    [Validation(Required=true)]
                    public long? GmtModifiedTimestamp { get; set; }

                    [NameInMap("ConfigList")]
                    [Validation(Required=true)]
                    public QueryEdgeInstanceChannelResponseDataChannelListChannelConfigList ConfigList { get; set; }
                    public class QueryEdgeInstanceChannelResponseDataChannelListChannelConfigList : TeaModel {
                        [NameInMap("Config")]
                        [Validation(Required=true)]
                        public List<QueryEdgeInstanceChannelResponseDataChannelListChannelConfigListConfig> Config { get; set; }
                        public class QueryEdgeInstanceChannelResponseDataChannelListChannelConfigListConfig : TeaModel {
                            public string ConfigId { get; set; }
                            public string Format { get; set; }
                            public string Content { get; set; }
                            public string Key { get; set; }
                        }
                    };

                }

            }
        };

    }

}
