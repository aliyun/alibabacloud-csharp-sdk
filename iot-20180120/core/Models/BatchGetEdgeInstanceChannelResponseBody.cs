// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceChannelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchGetEdgeInstanceChannelResponseBodyData Data { get; set; }
        public class BatchGetEdgeInstanceChannelResponseBodyData : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public List<BatchGetEdgeInstanceChannelResponseBodyDataChannel> Channel { get; set; }
            public class BatchGetEdgeInstanceChannelResponseBodyDataChannel : TeaModel {
                public string ChannelId { get; set; }
                public string ChannelName { get; set; }
                public BatchGetEdgeInstanceChannelResponseBodyDataChannelConfigList ConfigList { get; set; }
                public class BatchGetEdgeInstanceChannelResponseBodyDataChannelConfigList : TeaModel {
                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public List<BatchGetEdgeInstanceChannelResponseBodyDataChannelConfigListConfig> Config { get; set; }
                    public class BatchGetEdgeInstanceChannelResponseBodyDataChannelConfigListConfig : TeaModel {
                        [NameInMap("ConfigId")]
                        [Validation(Required=false)]
                        public string ConfigId { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                    }

                }
            }
        };

    }

}
