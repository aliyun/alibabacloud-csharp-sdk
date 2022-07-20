// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordTemplatesResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 数组，返回示例目录。
        /// </summary>
        [NameInMap("RecordTemplateList")]
        [Validation(Required=false)]
        public List<ListLiveRecordTemplatesResponseBodyRecordTemplateList> RecordTemplateList { get; set; }
        public class ListLiveRecordTemplatesResponseBodyRecordTemplateList : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 最后修改时间
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// 资源名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public byte[] Name { get; set; }

            /// <summary>
            /// 录制格式
            /// </summary>
            [NameInMap("RecordFormatList")]
            [Validation(Required=false)]
            public List<ListLiveRecordTemplatesResponseBodyRecordTemplateListRecordFormatList> RecordFormatList { get; set; }
            public class ListLiveRecordTemplatesResponseBodyRecordTemplateListRecordFormatList : TeaModel {
                /// <summary>
                /// 录制周期时长
                /// </summary>
                [NameInMap("CycleDuration")]
                [Validation(Required=false)]
                public byte[] CycleDuration { get; set; }

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

            /// <summary>
            /// 资源一级ID
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public byte[] TemplateId { get; set; }

            /// <summary>
            /// 资源名称
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public byte[] Type { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
