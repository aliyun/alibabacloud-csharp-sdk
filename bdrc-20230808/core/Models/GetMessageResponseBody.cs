// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class GetMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMessageResponseBodyData Data { get; set; }
        public class GetMessageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{********}</para>
            /// </summary>
            [NameInMap("MessageContent")]
            [Validation(Required=false)]
            public string MessageContent { get; set; }

            /// <summary>
            /// <para>Message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-123***7890</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>Message level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("MessageLevel")]
            [Validation(Required=false)]
            public string MessageLevel { get; set; }

            /// <summary>
            /// <para>Message name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyMessage</para>
            /// </summary>
            [NameInMap("MessageName")]
            [Validation(Required=false)]
            public string MessageName { get; set; }

            /// <summary>
            /// <para>Message source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-123***7890</para>
            /// </summary>
            [NameInMap("MessageSourceId")]
            [Validation(Required=false)]
            public string MessageSourceId { get; set; }

            /// <summary>
            /// <para>Message source region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("MessageSourceRegionId")]
            [Validation(Required=false)]
            public string MessageSourceRegionId { get; set; }

            /// <summary>
            /// <para>Message source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROTECTION_POLICY</para>
            /// </summary>
            [NameInMap("MessageSourceType")]
            [Validation(Required=false)]
            public string MessageSourceType { get; set; }

            /// <summary>
            /// <para>Message time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740019609</para>
            /// </summary>
            [NameInMap("MessageTime")]
            [Validation(Required=false)]
            public long? MessageTime { get; set; }

            /// <summary>
            /// <para>Message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUB_PROTECTION_POLICY_MODIFIED</para>
            /// </summary>
            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8724BC18-904D-5A0D-BFF4-F0554F0037E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
