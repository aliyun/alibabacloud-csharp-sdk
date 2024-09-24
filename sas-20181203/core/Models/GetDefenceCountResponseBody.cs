// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDefenceCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of handled alerts of the precise defense type in the last 15 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefenceCount15Days")]
        [Validation(Required=false)]
        public int? DefenceCount15Days { get; set; }

        /// <summary>
        /// <para>The number of handled alerts of the precision defense type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefenceCountTotal")]
        [Validation(Required=false)]
        public int? DefenceCountTotal { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89AD16CC-97EE-50F3-9B12-9E28E5C8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of handled alerts of the web tamper proofing type in the last 15 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TamperProof15Days")]
        [Validation(Required=false)]
        public int? TamperProof15Days { get; set; }

        /// <summary>
        /// <para>The number of handled alerts of the web tamper proofing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TamperProofTotal")]
        [Validation(Required=false)]
        public int? TamperProofTotal { get; set; }

    }

}
