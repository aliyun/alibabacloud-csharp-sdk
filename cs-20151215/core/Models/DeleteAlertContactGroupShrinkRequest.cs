// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert contact group IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_group_ids")]
        [Validation(Required=false)]
        public string ContactGroupIdsShrink { get; set; }

    }

}
