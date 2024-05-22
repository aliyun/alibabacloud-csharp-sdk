// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordTemplateResponseBody : TeaModel {
        /// <summary>
        /// 录制模板
        /// </summary>
        [NameInMap("RecordTemplate")]
        [Validation(Required=false)]
        public GetLiveRecordTemplateResponseBodyRecordTemplate RecordTemplate { get; set; }
        public class GetLiveRecordTemplateResponseBodyRecordTemplate : TeaModel {
            /// <summary>
            /// 代表创建时间的资源属性字段
            /// 
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 代表创建时间的资源属性字段
            /// 
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 录制格式
            /// </summary>
            [NameInMap("RecordFormatList")]
            [Validation(Required=false)]
            public List<GetLiveRecordTemplateResponseBodyRecordTemplateRecordFormatList> RecordFormatList { get; set; }
            public class GetLiveRecordTemplateResponseBodyRecordTemplateRecordFormatList : TeaModel {
                [NameInMap("CycleDuration")]
                [Validation(Required=false)]
                public int? CycleDuration { get; set; }

                /// <summary>
                /// 格式
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// Oss对象名，不包含后缀
                /// </summary>
                [NameInMap("OssObjectPrefix")]
                [Validation(Required=false)]
                public string OssObjectPrefix { get; set; }

                [NameInMap("SliceDuration")]
                [Validation(Required=false)]
                public int? SliceDuration { get; set; }

                /// <summary>
                /// 切片Oss对象名，不包含后缀
                /// </summary>
                [NameInMap("SliceOssObjectPrefix")]
                [Validation(Required=false)]
                public string SliceOssObjectPrefix { get; set; }

            }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
