// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateGroupPublicUrlResponseBody : TeaModel {
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
        /// <para>The folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-12T03:08:56Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The project group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_delivery</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The knowledge base name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-toolset-80a4520e-b35c-4e8b-acf7-3a01c7307522</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The URL of the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://mp.weixin.qq.com/s/iHqLKhkJcOyHNCOGejO32A">https://mp.weixin.qq.com/s/iHqLKhkJcOyHNCOGejO32A</a></para>
        /// </summary>
        [NameInMap("originalUrl")]
        [Validation(Required=false)]
        public string OriginalUrl { get; set; }

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
        /// <para>The permission scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERSONAL</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceId</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The refund status. If a refund is in progress, query to confirm the refund status. Valid values:</para>
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
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
