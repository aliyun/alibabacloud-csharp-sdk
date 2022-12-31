// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordJobResponseBody : TeaModel {
        /// <summary>
        /// 录制任务
        /// </summary>
        [NameInMap("RecordJob")]
        [Validation(Required=false)]
        public GetLiveRecordJobResponseBodyRecordJob RecordJob { get; set; }
        public class GetLiveRecordJobResponseBodyRecordJob : TeaModel {
            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 回调地址
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public GetLiveRecordJobResponseBodyRecordJobRecordOutput RecordOutput { get; set; }
            public class GetLiveRecordJobResponseBodyRecordJobRecordOutput : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public GetLiveRecordJobResponseBodyRecordJobStreamInput StreamInput { get; set; }
            public class GetLiveRecordJobResponseBodyRecordJobStreamInput : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 录制模板ID
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// 录制模板ID
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
