// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class ConfigXRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the call capability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Disable.</para>
        /// </description></item>
        /// <item><description><para>1: Enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallAbility")]
        [Validation(Required=false)]
        public string CallAbility { get; set; }

        /// <summary>
        /// <para>The customer UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1898871967585852</para>
        /// </summary>
        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC5**********************a1a</para>
        /// </summary>
        [NameInMap("CustomerPoolKey")]
        [Validation(Required=false)]
        public string CustomerPoolKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to pass through the caller ID to display the actual caller. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>00: No pass-through. The work number is displayed when either party calls the other.</para>
        /// </description></item>
        /// <item><description><para>10: Pass-through. When Customer A is the caller, the caller ID displayed to Employee B is the number of Customer A. When Employee B is the caller, the caller ID displayed to Customer A is the work number.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GNFlag")]
        [Validation(Required=false)]
        public string GNFlag { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The request deduplication ID. The maximum length of reqId is 20 characters. The caller must ensure atomicity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>564**********879</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The sequential ringing control parameters.</para>
        /// </summary>
        [NameInMap("SequenceCalls")]
        [Validation(Required=false)]
        public List<ConfigXRequestSequenceCalls> SequenceCalls { get; set; }
        public class ConfigXRequestSequenceCalls : TeaModel {
            /// <summary>
            /// <para>The playback code for the sequential ringing prompt tone. The format is the same as callNoPlayCode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("SequenceCallNoPlayCode")]
            [Validation(Required=false)]
            public string SequenceCallNoPlayCode { get; set; }

            /// <summary>
            /// <para>The callee number for sequential ringing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18*******33</para>
            /// </summary>
            [NameInMap("SequenceCalledNo")]
            [Validation(Required=false)]
            public string SequenceCalledNo { get; set; }

            /// <summary>
            /// <para>The playback code for the caller and callee after the call is connected. The format is the same as calledPlayCode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("SequenceCalledPlayCode")]
            [Validation(Required=false)]
            public string SequenceCalledPlayCode { get; set; }

        }

        /// <summary>
        /// <para>The sequential ringing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: No sequential ringing. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>1: Conditional sequential ringing. The system first connects to the callee specified by calledNo. If the callee cannot be connected, the system sequentially rings the numbers in the sequenceCalls list.</para>
        /// </description></item>
        /// <item><description><para>2: Unconditional sequential ringing. The system does not connect to the callee specified by calledNo and directly sequentially rings the numbers in the sequenceCalls list.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SequenceMode")]
        [Validation(Required=false)]
        public string SequenceMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SMS feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Disable.</para>
        /// </description></item>
        /// <item><description><para>1: Enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsAbility")]
        [Validation(Required=false)]
        public string SmsAbility { get; set; }

        /// <summary>
        /// <para>Specifies whether to pass through the SMS signature to display the actual user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: No pass-through.</para>
        /// </description></item>
        /// <item><description><para>1: Pass-through.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSignMode")]
        [Validation(Required=false)]
        public string SmsSignMode { get; set; }

        /// <summary>
        /// <para>The X number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17*******22</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
