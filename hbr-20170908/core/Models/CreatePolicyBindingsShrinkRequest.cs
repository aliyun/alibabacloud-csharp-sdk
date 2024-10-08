// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyBindingsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data sources that you want to bind to the backup policy.</para>
        /// </summary>
        [NameInMap("PolicyBindingList")]
        [Validation(Required=false)]
        public string PolicyBindingListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************8ep</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
