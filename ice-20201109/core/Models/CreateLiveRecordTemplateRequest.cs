// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// 资源名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public byte[] Name { get; set; }

        /// <summary>
        /// 录制格式
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
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public byte[] Format { get; set; }

            /// <summary>
            /// Oss对象名
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public byte[] OssObjectPrefix { get; set; }

            /// <summary>
            /// 切片时长
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// 切片Oss对象名
            /// </summary>
            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public byte[] SliceOssObjectPrefix { get; set; }

        }

    }

}
