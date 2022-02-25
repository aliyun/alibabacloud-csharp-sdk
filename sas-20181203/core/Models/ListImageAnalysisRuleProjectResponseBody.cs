// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageAnalysisRuleProjectResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImageAnalysisRuleProjectResponseBodyData> Data { get; set; }
        public class ListImageAnalysisRuleProjectResponseBodyData : TeaModel {
            /// <summary>
            /// 规则内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 是否gzip压缩
            /// </summary>
            [NameInMap("IsCompress")]
            [Validation(Required=false)]
            public bool? IsCompress { get; set; }

            /// <summary>
            /// 是否加密
            /// </summary>
            [NameInMap("IsEncrypt")]
            [Validation(Required=false)]
            public bool? IsEncrypt { get; set; }

            /// <summary>
            /// 规则名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 输出配置
            /// </summary>
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public string OutputConfig { get; set; }

            /// <summary>
            /// 处理handler
            /// </summary>
            [NameInMap("OutputHandler")]
            [Validation(Required=false)]
            public string OutputHandler { get; set; }

            /// <summary>
            /// 项目名称
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// 规则状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 规则版本
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
