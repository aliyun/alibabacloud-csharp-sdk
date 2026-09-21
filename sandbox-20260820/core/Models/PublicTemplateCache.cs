// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateCache : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-18T10:00:00Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sha256:8f3c2a1b</para>
        /// </summary>
        [NameInMap("imageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("imageSizeMB")]
        [Validation(Required=false)]
        public int? ImageSizeMB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-18T10:05:00Z</para>
        /// </summary>
        [NameInMap("readyTime")]
        [Validation(Required=false)]
        public string ReadyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>镜像预热任务排队中</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13b721e6-8cc8-5df2-af13-80316f7508af</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>us7dxqaezw5uu7aa2cm5</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
