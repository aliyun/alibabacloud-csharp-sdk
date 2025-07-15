// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageAppAuditResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The signature of the interactive messaging application. It is required by the interactive messaging SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppSign")]
        [Validation(Required=false)]
        public string AppSign { get; set; }

        /// <summary>
        /// <para>Indicates whether authentication is enabled. If custom content moderation is used, the value of this parameter is true by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuditNeedAuthentication")]
        [Validation(Required=false)]
        public bool? AuditNeedAuthentication { get; set; }

        /// <summary>
        /// <para>The content moderation method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>The URL for content moderation. This parameter is returned when the value of AuditType is 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http: //example.aliyundoc.com/exampleaudit</para>
        /// </summary>
        [NameInMap("AuditUrl")]
        [Validation(Required=false)]
        public string AuditUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C4E8440-3838-1831-9BDE-AFC15803****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
