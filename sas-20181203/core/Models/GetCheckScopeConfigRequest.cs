// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckScopeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration. This parameter is optional. If you do not specify this parameter, a default ID is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>435f626256ebf564cf5ba966a539****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
