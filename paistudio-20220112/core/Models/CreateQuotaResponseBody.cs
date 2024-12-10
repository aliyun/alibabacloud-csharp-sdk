// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>Quota Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotad2kd8ljpsno</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBF05F13-B24C-5129-9048-4FA684DCD579</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
