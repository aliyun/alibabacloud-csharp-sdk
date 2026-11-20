// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnExtensionFixedLineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Caller-side ringtone code. This parameter is required for AXB scenarios. Must contain codes for 3 scenarios. Enter the codes in the order of &quot;B-&gt;X, A-&gt;X, other numbers-&gt;X&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>&quot;1,2,3&quot; indicates that the ringtone code for B-&gt;X is 1, for A-&gt;X is 2, and for other numbers-&gt;X is 3.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("Anucode")]
        [Validation(Required=false)]
        public string Anucode { get; set; }

        /// <summary>
        /// <para>Called-side ringtone code after connection. Must contain codes for 2 scenarios. Enter the codes in the order of &quot;A as called party, B as called party&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>&quot;1,2&quot; indicates that the ringtone code when A is the called party is 1, and the ringtone code when B is the called party is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("Anucodecalled")]
        [Validation(Required=false)]
        public string Anucodecalled { get; set; }

        /// <summary>
        /// <para>Number pool ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000016848****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Area code. Supports specifying the home location of the X number (specified city -&gt; provincial capital -&gt; nationwide routing). If no home location is specified, a number is randomly assigned nationwide.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571</para>
        /// </summary>
        [NameInMap("Areacode")]
        [Validation(Required=false)]
        public string Areacode { get; set; }

        /// <summary>
        /// <para>Binding type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>mode101: Customer specifies the X number.</para>
        /// </description></item>
        /// <item><description><para>mode102: Platform assigns the X number.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mode101</para>
        /// </summary>
        [NameInMap("BindType")]
        [Validation(Required=false)]
        public string BindType { get; set; }

        /// <summary>
        /// <para>Expiration time. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Never expires.</para>
        /// </description></item>
        /// <item><description><para>Other values: When other values are specified, such as 60, the binding is valid for 60 seconds after the X number is successfully assigned. After 60 seconds, the binding is automatically released.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Extension parameters.</para>
        /// </summary>
        [NameInMap("Extraaxx")]
        [Validation(Required=false)]
        public string ExtraaxxShrink { get; set; }

        /// <summary>
        /// <para>Unique identifier of the message request.</para>
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
        /// <para>External business extension field. This parameter is returned in call record receipt messages. Must not exceed 100 characters.</para>
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
        /// <para>Binding time. Format: yyyyMMddHHmmss. Uses Beijing time, 24-hour clock.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20161114143116</para>
        /// </summary>
        [NameInMap("Subts")]
        [Validation(Required=false)]
        public string Subts { get; set; }

        /// <summary>
        /// <para>Caller-side ringtone code after connection. Must contain codes for 2 scenarios. Enter the codes in the order of &quot;A as called party, B as called party&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>&quot;1,2&quot; indicates that the caller-side ringtone code when A is the called party is 1, and the caller-side ringtone code when B is the called party is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>The A number for the fixed-line AXN extension number.</para>
        /// <remarks>
        /// <para>The A number can be set to a mobile number or a fixed-line number. Fixed-line numbers must include the area code, and no hyphen is needed between the area code and the number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mobile: 182<b><b>2371
        /// Fixed line: 0571</b></b>**36</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>The X number for the fixed-line AXN extension number. The X number is a privacy number that you have <a href="https://dyplsnext.console.aliyun.com/numberbuy">purchased</a> in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571******23</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

        /// <summary>
        /// <para>Extension number. This parameter is required when the BindType parameter is set to mode101.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1009</para>
        /// </summary>
        [NameInMap("TelXext")]
        [Validation(Required=false)]
        public string TelXext { get; set; }

        /// <summary>
        /// <para>Business timestamp. Format: yyyyMMddHHmmssSSS. Uses Beijing time, 24-hour clock, accurate to milliseconds.</para>
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
