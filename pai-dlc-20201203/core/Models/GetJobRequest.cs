// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the job details. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedDetail")]
        [Validation(Required=false)]
        public bool? NeedDetail { get; set; }

    }

}
