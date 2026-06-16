// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UpdateAuditRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The approval comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同意</para>
        /// </summary>
        [NameInMap("auditMsg")]
        [Validation(Required=false)]
        public string AuditMsg { get; set; }

        /// <summary>
        /// <para>The association type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RULE</para>
        /// </summary>
        [NameInMap("auditRelationType")]
        [Validation(Required=false)]
        public string AuditRelationType { get; set; }

        /// <summary>
        /// <para>The approval status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGREE</para>
        /// </summary>
        [NameInMap("auditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// <para>The ID of the approval to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>376773</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}
