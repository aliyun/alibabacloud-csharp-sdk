// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateAxnBindFixedLineRequest : TeaModel {
        /// <summary>
        /// <para>The prompt code for the caller side. This parameter is required for AXB services. The codes must include three scenarios. Enter the codes in the order of B-&gt;X, A-&gt;X, and other numbers-&gt;X, separated by commas.</para>
        /// <remarks>
        /// <para>1,2,3 indicates that the prompt code for B-&gt;X is 1, the prompt code for A-&gt;X is 2, and the prompt code for other numbers-&gt;X is 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("Anucode")]
        [Validation(Required=false)]
        public string Anucode { get; set; }

        /// <summary>
        /// <para>The prompt code for the callee side after the call is connected. The codes must include two scenarios. Enter the codes in the order of A as callee and B as callee, separated by commas.</para>
        /// <remarks>
        /// <para>1,2 indicates that the prompt code when A is the callee is 1, and the prompt code when B is the callee is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("Anucodecalled")]
        [Validation(Required=false)]
        public string Anucodecalled { get; set; }

        /// <summary>
        /// <para>The ID of the number pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000016848****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The expiration time. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Never expires.</para>
        /// </description></item>
        /// <item><description><para>Other values: If you specify another value, such as 60, the binding is valid for 60 seconds after the number X is allocated. After 60 seconds, the binding is automatically unbound.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>The extended parameters.</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public UpdateAxnBindFixedLineRequestExtra Extra { get; set; }
        public class UpdateAxnBindFixedLineRequestExtra : TeaModel {
            /// <summary>
            /// <para>The callback control. This applies when A calls through X, meaning A is the caller and X is the callee. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (default): Outbound calls are not allowed.</para>
            /// </description></item>
            /// <item><description><para>1: Connect to the most recent number N.</para>
            /// </description></item>
            /// <item><description><para>2: Call back the fixed number TelB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            /// <summary>
            /// <para>The call recording control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (default): Do not record.</para>
            /// </description></item>
            /// <item><description><para>1: Record.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>After you enable call recording, you can play and download audio files in the call records. Audio files are billed at CNY 0.010 per minute.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Callrecording")]
            [Validation(Required=false)]
            public string Callrecording { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the message request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123*******</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The external business extension field. This parameter is returned in the call record receipt message. The maximum length is 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19394</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The binding ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GHX0*************************</para>
        /// </summary>
        [NameInMap("SubId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

        /// <summary>
        /// <para>The binding time. The format is yyyyMMddHHmmss. The time is in UTC+8 and uses a 24-hour clock.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20161114143116</para>
        /// </summary>
        [NameInMap("Subts")]
        [Validation(Required=false)]
        public string Subts { get; set; }

        /// <summary>
        /// <para>The prompt code for the caller side after the call is connected. The codes must include two scenarios. Enter the codes in the order of A as callee and B as callee, separated by commas.</para>
        /// <remarks>
        /// <para>1,2 indicates that the prompt code for the caller side when A is the callee is 1, and the prompt code for the caller side when B is the callee is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>The number A of the landline AXN privacy number.</para>
        /// <remarks>
        /// <para>You can set number A to a mobile phone number or a landline number. If you use a landline number, you must include the area code. Do not add a hyphen between the area code and the phone number.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Mobile phone number: 182<b><b>2371
        /// Landline number: 0571</b></b>**36</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>The number N of the landline AXN privacy number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>155****2222</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>The business timestamp. The format is yyyyMMddHHmmssSSS. The time is in UTC+8 and uses a 24-hour clock, accurate to milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20161114143116123</para>
        /// </summary>
        [NameInMap("Ts")]
        [Validation(Required=false)]
        public string Ts { get; set; }

    }

}
