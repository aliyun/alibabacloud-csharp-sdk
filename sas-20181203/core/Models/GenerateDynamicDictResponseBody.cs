// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateDynamicDictResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom weak passwords.</para>
        /// </summary>
        [NameInMap("KeywordList")]
        [Validation(Required=false)]
        public List<string> KeywordList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00E9B912-6066-5E4E-9F24-35EA09F2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
