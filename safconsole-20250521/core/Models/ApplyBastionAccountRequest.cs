// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class ApplyBastionAccountRequest : TeaModel {
        /// <summary>
        /// <para>Mobile Phone Number</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public long? Mobile { get; set; }

        /// <summary>
        /// <para>Project ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>90912</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
