// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class TranscribeChatVoiceAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The content type of the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image.</description></item>
        /// <item><description><b>document</b>: General document.</description></item>
        /// <item><description><b>alidoc</b>: AliDoc.</description></item>
        /// <item><description><b>text</b>: Text.</description></item>
        /// <item><description><b>video</b>: Video.</description></item>
        /// <item><description><b>audio</b>: Audio.</description></item>
        /// <item><description><b>archive</b>: Archive.</description></item>
        /// <item><description><b>app</b>: Application.</description></item>
        /// <item><description><b>link</b>: Shortcut.</description></item>
        /// <item><description><b>other</b>: Other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>audio/mpeg</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The standard Base64-encoded audio content, excluding the data URI prefix. This parameter and FileUrl are mutually exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UklGRg==</para>
        /// </summary>
        [NameInMap("fileContentBase64")]
        [Validation(Required=false)]
        public string FileContentBase64 { get; set; }

        /// <summary>
        /// <para>The full path and name of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>meeting.mp3</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The publicly accessible URL of the attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://winnexo-file-transfer.oss-cn-hangzhou.aliyuncs.com/openapi/2026-09-08/9f8c2a1b">http://winnexo-file-transfer.oss-cn-hangzhou.aliyuncs.com/openapi/2026-09-08/9f8c2a1b</a></para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
