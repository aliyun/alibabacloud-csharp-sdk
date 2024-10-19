// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeBackendInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>739b68751c0b4e899e04d0c92b6d0be7</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
