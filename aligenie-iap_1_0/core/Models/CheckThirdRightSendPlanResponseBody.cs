// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CheckThirdRightSendPlanResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public CheckThirdRightSendPlanResponseBodyRetValue RetValue { get; set; }
        public class CheckThirdRightSendPlanResponseBodyRetValue : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;1713262192005&quot;</para>
            /// </summary>
            [NameInMap("ActivateDate")]
            [Validation(Required=false)]
            public string ActivateDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001 日卡 1002 月卡 1003 季卡 1004 年卡</para>
            /// </summary>
            [NameInMap("CardType")]
            [Validation(Required=false)]
            public int? CardType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TB</para>
            /// </summary>
            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>淘宝</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>908FA068-529C-0C20-8DB5-63B0EF7CFF1F</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;1713262192005&quot;</para>
            /// </summary>
            [NameInMap("RightsExpiredDate")]
            [Validation(Required=false)]
            public string RightsExpiredDate { get; set; }

        }

    }

}
