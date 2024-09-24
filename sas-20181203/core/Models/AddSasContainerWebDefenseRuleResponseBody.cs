// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddSasContainerWebDefenseRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique value of the created rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200634</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B4B6E6D-B0B0-5F05-A14E-82917D9648EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
