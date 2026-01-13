// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class GetAccountConfigInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("accountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-12 12:00:00</para>
        /// </summary>
        [NameInMap("availableTime")]
        [Validation(Required=false)]
        public string AvailableTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("billQps")]
        [Validation(Required=false)]
        public string BillQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FixLadder</para>
        /// </summary>
        [NameInMap("ladderType")]
        [Validation(Required=false)]
        public string LadderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12123123123</para>
        /// </summary>
        [NameInMap("mainAccountId")]
        [Validation(Required=false)]
        public string MainAccountId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6788a2c2-157d4ebe-ad979cd4f296</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
