// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// 事件源列表
        /// </summary>
        [NameInMap("eventSources")]
        [Validation(Required=false)]
        public List<ListEventSourcesResponseBodyEventSources> EventSources { get; set; }
        public class ListEventSourcesResponseBodyEventSources : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 事件源资源标识符
            /// </summary>
            [NameInMap("sourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

        }

    }

}
