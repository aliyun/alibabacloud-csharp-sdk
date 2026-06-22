// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteInterceptionTargetRequest : TeaModel {
        /// <summary>
        /// <para>The list of network object IDs to delete.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,11,111</para>
        /// </summary>
        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public string TargetIds { get; set; }

    }

}
