// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteManifestEditTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ManifestEdit template to be deleted. Only letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c6581d59240de5e258ffa4c71a3e01b</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
