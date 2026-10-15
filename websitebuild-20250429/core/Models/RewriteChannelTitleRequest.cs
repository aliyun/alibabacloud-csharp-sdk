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
        /// <para>The user personalization requirement in free text. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("UserRequirement")]
        [Validation(Required=false)]
        public string UserRequirement { get; set; }

    }

}
