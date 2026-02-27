// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitVideoAuditRequest : TeaModel {
        /// <summary>
        /// <para>扩展参数JSON字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>OSS文件Key，与url参数二选一</para>
        /// 
        /// <b>Example:</b>
        /// <para>video/test.mp4</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <para>抽帧间隔时间（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("SnapshotInterval")]
        [Validation(Required=false)]
        public double? SnapshotInterval { get; set; }

        /// <summary>
        /// <para>视频URL地址，与fileKey参数二选一</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/video.mp4">https://example.com/video.mp4</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
