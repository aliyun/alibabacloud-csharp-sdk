// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackTypeListResponseBody : TeaModel {
        [NameInMap("AttackTypeList")]
        [Validation(Required=false)]
        public List<GetAttackTypeListResponseBodyAttackTypeList> AttackTypeList { get; set; }
        public class GetAttackTypeListResponseBodyAttackTypeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sas.attack.type.type12</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alinet</para>
            /// </summary>
            [NameInMap("Status_Type")]
            [Validation(Required=false)]
            public string StatusType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>upload</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
