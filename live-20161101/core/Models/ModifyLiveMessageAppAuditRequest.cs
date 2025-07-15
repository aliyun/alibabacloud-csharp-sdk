// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageAppAuditRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application whose content moderation settings you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The content moderation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disables content moderation.</description></item>
        /// <item><description>1: uses built-in content moderation.</description></item>
        /// <item><description>2: uses custom content moderation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>The URL for content moderation. This parameter is required if you set AuditType to 2. The URL must start with http:// or https:// and cannot contain a private IP address or a port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/exampleaudit">http://example.aliyundoc.com/exampleaudit</a></para>
        /// </summary>
        [NameInMap("AuditUrl")]
        [Validation(Required=false)]
        public string AuditUrl { get; set; }

        /// <summary>
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

    }

}
