// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAITemplateRequest : TeaModel {
        /// <summary>
        /// <para>The type of the AI template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AIMediaAudit</b>: automated review</description></item>
        /// <item><description><b>AIImage</b>: smart thumbnail</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIMediaAudit</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
