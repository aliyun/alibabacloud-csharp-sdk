// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnFullDomainsBlockIPConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1.XXX.XXX.1,2.XXX.XXX.2</para>
        /// </summary>
        [NameInMap("IPList")]
        [Validation(Required=false)]
        public string IPList { get; set; }

    }

}
