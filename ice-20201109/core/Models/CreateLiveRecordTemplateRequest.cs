// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>代表资源名称的资源属性字段</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>录制格式</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<CreateLiveRecordTemplateRequestRecordFormat> RecordFormat { get; set; }
        public class CreateLiveRecordTemplateRequestRecordFormat : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>格式</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Oss对象名，不包含后缀</para>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            /// <summary>
            /// <para>切片时长</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>切片Oss对象名，不包含后缀</para>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{UnixTimestamp}_{Sequence}</para>
            /// </summary>
            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public string SliceOssObjectPrefix { get; set; }

        }

    }

}
