// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateWebFilterTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the web filtering template. The description can be up to 128 characters in length. If this parameter is not specified, the original value is retained. If an empty string is specified, the description is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web filtering template for URL access control</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the web filtering template. The name must be 1 to 64 characters in length, and can contain Chinese characters, letters, digits, hyphens (-), underscores (_), and periods (.). It cannot contain spaces. If this parameter is not specified or is left empty, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web filtering template 02</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the web filtering template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.
        /// If this parameter is not specified or is left empty, the original value is retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the web filtering template to be modified. The template must exist within the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft-3f2a9c1d4b5e6f70</para>
        /// </summary>
        [NameInMap("WebFilterTemplateId")]
        [Validation(Required=false)]
        public string WebFilterTemplateId { get; set; }

    }

}
