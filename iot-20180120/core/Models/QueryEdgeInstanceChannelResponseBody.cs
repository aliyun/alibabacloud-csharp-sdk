// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceChannelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceChannelResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceChannelResponseBodyData : TeaModel {
            [NameInMap("ChannelList")]
            [Validation(Required=false)]
            public QueryEdgeInstanceChannelResponseBodyDataChannelList ChannelList { get; set; }
            public class QueryEdgeInstanceChannelResponseBodyDataChannelList : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public List<QueryEdgeInstanceChannelResponseBodyDataChannelListChannel> Channel { get; set; }
                public class QueryEdgeInstanceChannelResponseBodyDataChannelListChannel : TeaModel {
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    [NameInMap("ChannelName")]
                    [Validation(Required=false)]
                    public string ChannelName { get; set; }

                    [NameInMap("ConfigList")]
                    [Validation(Required=false)]
                    public QueryEdgeInstanceChannelResponseBodyDataChannelListChannelConfigList ConfigList { get; set; }
                    public class QueryEdgeInstanceChannelResponseBodyDataChannelListChannelConfigList : TeaModel {
                        [NameInMap("Config")]
                        [Validation(Required=false)]
                        public List<QueryEdgeInstanceChannelResponseBodyDataChannelListChannelConfigListConfig> Config { get; set; }
                        public class QueryEdgeInstanceChannelResponseBodyDataChannelListChannelConfigListConfig : TeaModel {
                            public string ConfigId { get; set; }
                            public string Content { get; set; }
                            public string Format { get; set; }
                            public string Key { get; set; }
                        }
                    };

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtCreateTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtCreateTimestamp { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtModifiedTimestamp")]
                    [Validation(Required=false)]
                    public long? GmtModifiedTimestamp { get; set; }

                }

            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
