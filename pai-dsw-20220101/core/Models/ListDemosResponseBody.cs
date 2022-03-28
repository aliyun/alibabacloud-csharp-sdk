// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListDemosResponseBody : TeaModel {
        /// <summary>
        /// 样例列表
        /// </summary>
        [NameInMap("Demos")]
        [Validation(Required=false)]
        public List<ListDemosResponseBodyDemos> Demos { get; set; }
        public class ListDemosResponseBodyDemos : TeaModel {
            /// <summary>
            /// 所在目录
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// 样例描述
            /// </summary>
            [NameInMap("DemoDescription")]
            [Validation(Required=false)]
            public string DemoDescription { get; set; }

            /// <summary>
            /// 样例名称
            /// </summary>
            [NameInMap("DemoName")]
            [Validation(Required=false)]
            public string DemoName { get; set; }

            /// <summary>
            /// 样例地址
            /// </summary>
            [NameInMap("DemoUrl")]
            [Validation(Required=false)]
            public string DemoUrl { get; set; }

            /// <summary>
            /// 序号
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            /// <summary>
            /// 大小
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
