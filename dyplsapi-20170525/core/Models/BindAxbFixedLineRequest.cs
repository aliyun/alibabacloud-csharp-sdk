// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxbFixedLineRequest : TeaModel {
        /// <summary>
        /// <para>The caller-side announcement code. This parameter is required for the fixed-line AXB privacy number service. The code must include announcements for three scenarios. Specify the codes in the order of &quot;B-&gt;X, A-&gt;X, other numbers-&gt;X&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>For example, &quot;1,2,3&quot; indicates that the announcement code for B-&gt;X is 1, the announcement code for A-&gt;X is 2, and the announcement code for other numbers-&gt;X is 3.</para>
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
        /// <para>The callee-side announcement code after the call is connected. The code must include announcements for two scenarios. Specify the codes in the order of &quot;A as callee, B as callee&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>For example, &quot;1,2&quot; indicates that the announcement code when Number A answers as the callee is 1, and the announcement code when Number B answers as the callee is 2.</para>
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
        /// <para>The area code. You can specify the location of Number X (specified city -&gt; provincial capital -&gt; national routing). If you do not specify a location, a number is randomly assigned nationwide.</para>
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
        /// <item><description><para>mode101: The customer specifies Number X.</para>
        /// </description></item>
        /// <item><description><para>mode102: The platform allocates Number X.</para>
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
        /// <item><description><para>Other values: If you specify another value, such as 60, the binding is valid for 60 seconds after Number X is successfully allocated. After 60 seconds, the binding is automatically unbound.</para>
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
        public BindAxbFixedLineRequestExtra Extra { get; set; }
        public class BindAxbFixedLineRequestExtra : TeaModel {
            /// <summary>
            /// <para>The call recording control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (default): Do not record the call.</para>
            /// </description></item>
            /// <item><description><para>1: Record the call.</para>
            /// <remarks>
            /// <para>After you enable call recording, you can play and download voice files in the call records. Recording files are billed at CNY 0.010 per minute.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
        /// <para>The caller-side announcement code after the call is connected. The code must include announcements for two scenarios. Specify the codes in the order of &quot;A as callee, B as callee&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>For example, &quot;1,2&quot; indicates that the caller-side announcement code when Number A is the callee is 1, and the caller-side announcement code when Number B is the callee is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>Number A of the fixed-line AXB privacy number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Number A can be a mobile phone number or a fixed-line number. For a fixed-line number, add the area code. No hyphen is required between the area code and the fixed-line number. </description></item>
        /// <item><description>If your business requires modifying a bound number, you can call the <a href="https://api.aliyun.com/document/Dyplsapi/2017-05-25/UpdateAxbBindFixedLine">UpdateAxbBindFixedLine</a> operation.</description></item>
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
        /// <para>Number B of the fixed-line AXB privacy number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Number B can be a mobile phone number or a fixed-line number. For a fixed-line number, add the area code. No hyphen is required between the area code and the fixed-line number.</description></item>
        /// <item><description>If your business requires modifying a bound number, you can call the <a href="https://api.aliyun.com/document/Dyplsapi/2017-05-25/UpdateAxbBindFixedLine">UpdateAxbBindFixedLine</a> operation.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mobile phone number: 182<b><b>2371
        /// Fixed-line number: 0571</b></b>**36</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>Number X of the fixed-line AXB privacy number. Number X is a privacy number that you have <a href="https://dyplsnext.console.aliyun.com/numberbuy">purchased</a> in the console.</para>
        /// <remarks>
        /// <para>This parameter is required when the customer specifies Number X (that is, the BindType parameter is set to mode101).</para>
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
