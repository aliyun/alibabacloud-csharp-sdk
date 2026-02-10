// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveDelayConfigResponseBody : TeaModel {
        [NameInMap("DelayConfigList")]
        [Validation(Required=false)]
        public ListLiveDelayConfigResponseBodyDelayConfigList DelayConfigList { get; set; }
        public class ListLiveDelayConfigResponseBodyDelayConfigList : TeaModel {
            [NameInMap("DelayConfig")]
            [Validation(Required=false)]
            public List<ListLiveDelayConfigResponseBodyDelayConfigListDelayConfig> DelayConfig { get; set; }
            public class ListLiveDelayConfigResponseBodyDelayConfigListDelayConfig : TeaModel {
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public string DelayTime { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

                [NameInMap("TaskTriggerMode")]
                [Validation(Required=false)]
                public string TaskTriggerMode { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3136B58-5876-4168-83CA-B562781981A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of stream delay configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
