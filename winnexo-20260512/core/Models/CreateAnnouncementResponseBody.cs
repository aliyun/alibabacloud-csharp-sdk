// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateAnnouncementResponseBody : TeaModel {
        /// <summary>
        /// <para>The business ID of the notice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("announcementId")]
        [Validation(Required=false)]
        public long? AnnouncementId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public long? CreatedBy { get; set; }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The publish time in ISO 8601 format. This field is empty for drafts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T14:00:00+08:00</para>
        /// </summary>
        [NameInMap("publishedAt")]
        [Validation(Required=false)]
        public string PublishedAt { get; set; }

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
        /// <para>The source type of the dictionary file. Valid values: OSS: Object Storage Service (OSS). ORIGIN: retains the previously uploaded dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PLATFORM</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The refund status. You need to query and confirm the refund status during the refund process. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: All succeeded.</description></item>
        /// <item><description>FAIL: Failed.</description></item>
        /// <item><description>WAIT_PAY: Waiting for refund.</description></item>
        /// <item><description>EXPIRE: Expired.</description></item>
        /// <item><description>PAYING: Refund in progress.</description></item>
        /// <item><description>TERMINATE: Refund terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
