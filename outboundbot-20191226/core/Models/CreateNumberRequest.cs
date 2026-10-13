// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateNumberRequest : TeaModel {
        /// <summary>
        /// <para>The list of phone numbers to create and associate. A maximum of 100 phone numbers can be specified in a single request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public List<CreateNumberRequestNumbers> Numbers { get; set; }
        public class CreateNumberRequestNumbers : TeaModel {
            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>057188886666</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>The maximum number of requests allowed within the throttling period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RateLimitCount")]
            [Validation(Required=false)]
            public int? RateLimitCount { get; set; }

            /// <summary>
            /// <para>The throttling period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RateLimitPeriod")]
            [Validation(Required=false)]
            public int? RateLimitPeriod { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the SIP trunk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6bf8a1d2-3c4e-4f5a-9b8c-7d6e5f4a3b2c</para>
        /// </summary>
        [NameInMap("TrunkId")]
        [Validation(Required=false)]
        public string TrunkId { get; set; }

    }

}
