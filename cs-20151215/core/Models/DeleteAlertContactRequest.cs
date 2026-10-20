// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactRequest : Darabonba.Model {
        /// <summary>
        /// <para>The list of alert contact IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_ids")]
        [Validation(Required=false)]
        public List<long?> ContactIds { get; set; }

    }

}

