// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnFixedLineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The audio prompt codes for the caller side. The value must include codes for three scenarios. Specify the codes in the order of B-&gt;X, A-&gt;X, and other numbers-&gt;X, separated by commas.</para>
        /// <remarks>
        /// <para>For example, 1,2,3 indicates that the audio prompt code for B-&gt;X is 1, the code for A-&gt;X is 2, and the code for other numbers-&gt;X is 3.</para>
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
        /// <para>The audio prompt codes for the callee side. The value must include codes for two scenarios. Specify the codes in the order of A as the callee and other numbers as the callee, separated by commas.</para>
        /// <remarks>
        /// <para>For example, 1,2 indicates that the audio prompt code when number A answers as the callee is 1, and the code when other numbers answer as the callee is 2.</para>
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
        /// <para>The area code. You can specify the location of number X (specified city -&gt; provincial capital -&gt; national routing). If you do not specify the location, a number is randomly assigned nationwide.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571</para>
        /// </summary>
        [NameInMap("Areacode")]
        [Validation(Required=false)]
        public string Areacode { get; set; }

        /// <summary>
        /// <para>The binding type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>mode101: The customer specifies number X.</para>
        /// </description></item>
        /// <item><description><para>mode102: The platform assigns number X.</para>
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
        /// <para>The expiration time. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The binding never expires.</para>
        /// </description></item>
        /// <item><description><para>Other values: If you specify another value, such as 60, the binding is valid for 60 seconds after number X is successfully assigned. After 60 seconds, the binding is automatically unbound.</para>
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
        /// <para>The extended parameters.</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

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
        /// <para>The external business extension field. This parameter is returned in the call record receipt message. The value cannot exceed 100 characters in length.</para>
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
        /// <para>The binding time. The format is yyyyMMddHHmmss. The time is in UTC+8 and uses the 24-hour clock.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20161114143116</para>
        /// </summary>
        [NameInMap("Subts")]
        [Validation(Required=false)]
        public string Subts { get; set; }

        /// <summary>
        /// <para>The audio prompt codes for the caller side after the call is connected. The value must include codes for two scenarios. Specify the codes in the order of A as the callee and other numbers as the callee, separated by commas.</para>
        /// <remarks>
        /// <para>For example, 1,2 indicates that the audio prompt code for the caller side when number A is the callee is 1, and the code for the caller side when other numbers are the callee is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>Number A of the fixed-line AXN privacy number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Number A can be a mobile phone number or a fixed-line number. A fixed-line number must include the area code, and no hyphen is required between the area code and the number.</description></item>
        /// <item><description>If your business requires modifying a bound number, you can call the <a href="https://api.aliyun.com/document/Dyplsapi/2017-05-25/UpdateAxnBindFixedLine">UpdateAxnBindFixedLine</a> operation to modify it.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mobile phone number: 182<b><b>2371
        /// Fixed-line number: 0571</b></b>**36</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>Number N of the fixed-line AXN privacy number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>155****2222</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>Number X of the fixed-line AXN privacy number. Number X is the privacy number that you have purchased in the console.</para>
        /// <remarks>
        /// <para>This parameter is required in the mode where the customer specifies number X (that is, the BindType parameter is set to mode101).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0571******23</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

        /// <summary>
        /// <para>The business timestamp. The format is yyyyMMddHHmmssSSS. The time is in UTC+8 and uses the 24-hour clock, accurate to milliseconds.</para>
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
