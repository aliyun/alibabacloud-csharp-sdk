// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DeleteHiveRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-xxxx</para>
        /// </summary>
        [NameInMap("HiveId")]
        [Validation(Required=false)]
        public string HiveId { get; set; }

    }

}
