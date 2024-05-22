// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// 代表资源名称的资源属性字段
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 录制格式
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<CreateLiveRecordTemplateRequestRecordFormat> RecordFormat { get; set; }
        public class CreateLiveRecordTemplateRequestRecordFormat : TeaModel {
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// 格式
            /// 
            /// This parameter is required.
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

            /// <summary>
            /// 切片时长
            /// </summary>
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

    }

}
