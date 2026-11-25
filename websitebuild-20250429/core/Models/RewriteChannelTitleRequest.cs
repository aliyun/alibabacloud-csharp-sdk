// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RewriteChannelTitleRequest : TeaModel {
        /// <summary>
        /// <para>The channel draft ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c80359e-835d-4871-a971-8400d008828b</para>
        /// </summary>
        [NameInMap("DraftId")]
        [Validation(Required=false)]
        public string DraftId { get; set; }

        /// <summary>
        /// <para>The custom requirement specified by the user. This parameter is optional and accepts free text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Highlight the main features and keep the title concise and clear</para>
        /// </summary>
        [NameInMap("UserRequirement")]
        [Validation(Required=false)]
        public string UserRequirement { get; set; }

    }

}
