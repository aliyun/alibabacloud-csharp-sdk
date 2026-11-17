// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateShareResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid request parameters</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The output item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleOutputItemId</para>
        /// </summary>
        [NameInMap("outputItemId")]
        [Validation(Required=false)]
        public string OutputItemId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the function session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The current sharing scope. Valid values: PUBLIC and SPECIFIED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPECIFIED</para>
        /// </summary>
        [NameInMap("shareAccessType")]
        [Validation(Required=false)]
        public string ShareAccessType { get; set; }

        /// <summary>
        /// <para>Specifies whether sharing is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("shareEnabled")]
        [Validation(Required=false)]
        public bool? ShareEnabled { get; set; }

        /// <summary>
        /// <para>The time when sharing was most recently enabled, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-16T13:00:00+00:00</para>
        /// </summary>
        [NameInMap("shareEnabledAt")]
        [Validation(Required=false)]
        public string ShareEnabledAt { get; set; }

        /// <summary>
        /// <para>The relative path for in-site sharing. This parameter is empty when sharing is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/10001/share/output/token</para>
        /// </summary>
        [NameInMap("sharePath")]
        [Validation(Required=false)]
        public string SharePath { get; set; }

        /// <summary>
        /// <para>The sharing token, which is returned when sharing is enabled. You can use this token to access the public sharing preview API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleShareToken</para>
        /// </summary>
        [NameInMap("shareToken")]
        [Validation(Required=false)]
        public string ShareToken { get; set; }

        /// <summary>
        /// <para>The absolute URL of the current sharing link. This parameter is empty when sharing is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/10001/share/output/token">https://example.com/10001/share/output/token</a></para>
        /// </summary>
        [NameInMap("shareUrl")]
        [Validation(Required=false)]
        public string ShareUrl { get; set; }

        /// <summary>
        /// <para>The list of currently specified user group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("shareUserGroupIds")]
        [Validation(Required=false)]
        public List<string> ShareUserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of currently specified user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("shareUserIds")]
        [Validation(Required=false)]
        public List<long?> ShareUserIds { get; set; }

        /// <summary>
        /// <para>The type of the current permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>period: Period type.</description></item>
        /// <item><description>objective: Objective type.</description></item>
        /// <item><description>kr: Key result type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>outputItem</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
