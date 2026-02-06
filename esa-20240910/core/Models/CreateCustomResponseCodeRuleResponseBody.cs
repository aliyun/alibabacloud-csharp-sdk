// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCustomResponseCodeRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3528160969****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2B2F8CF-3074-5BBC-891A-AAD292E2624F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
