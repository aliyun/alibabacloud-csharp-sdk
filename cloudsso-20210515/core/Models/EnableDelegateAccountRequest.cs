// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class EnableDelegateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delegated administrator account of CloudSSO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180658567986****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
