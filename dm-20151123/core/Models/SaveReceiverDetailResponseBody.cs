// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SaveReceiverDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>List of recipient addresses that failed to upload.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SaveReceiverDetailResponseBodyData Data { get; set; }
        public class SaveReceiverDetailResponseBodyData : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<SaveReceiverDetailResponseBodyDataDetail> Detail { get; set; }
            public class SaveReceiverDetailResponseBodyDataDetail : TeaModel {
                /// <summary>
                /// <para>Recipient address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@example.com">test@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

            }

        }

        /// <summary>
        /// <para>Number of errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>638</para>
        /// </summary>
        [NameInMap("ErrorCount")]
        [Validation(Required=false)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of successes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>274</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
