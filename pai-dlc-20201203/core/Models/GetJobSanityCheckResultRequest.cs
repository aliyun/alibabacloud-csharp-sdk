// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobSanityCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SanityCheckNumber")]
        [Validation(Required=false)]
        public int? SanityCheckNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DeviceCheck</para>
        /// </summary>
        [NameInMap("SanityCheckPhase")]
        [Validation(Required=false)]
        public string SanityCheckPhase { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
