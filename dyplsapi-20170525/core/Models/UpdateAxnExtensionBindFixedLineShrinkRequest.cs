// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateAxnExtensionBindFixedLineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The announcement code for the caller side. This parameter is required for the AXB service. It must contain codes for three scenarios. Specify the codes in the order of &quot;B-&gt;X, A-&gt;X, and other numbers-&gt;X&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>&quot;1,2,3&quot; indicates that the announcement code for B-&gt;X is 1, the announcement code for A-&gt;X is 2, and the announcement code for other numbers-&gt;X is 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("Anucode")]
        [Validation(Required=false)]
        public string Anucode { get; set; }

        /// <summary>
        /// <para>The announcement code for the callee side after the call is connected. It must contain codes for two scenarios. Specify the codes in the order of &quot;A as callee and B as callee&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>&quot;1,2&quot; indicates that the announcement code when number A answers as the callee is 1, and the announcement code when number B answers as the callee is 2.</para>
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
        /// <item><description><para>Other values: If you specify another value, such as 60, the binding is valid for 60 seconds after number X is allocated. After 60 seconds, the binding is automatically unbound.</para>
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
        /// <para>The extension parameters.</para>
        /// </summary>
        [NameInMap("Extraaxx")]
        [Validation(Required=false)]
        public string ExtraaxxShrink { get; set; }

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
        /// <para>The binding time. Format: yyyyMMddHHmmss. The time is in UTC+8 and uses the 24-hour format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20161114143116</para>
        /// </summary>
        [NameInMap("Subts")]
        [Validation(Required=false)]
        public string Subts { get; set; }

        /// <summary>
        /// <para>The announcement code for the caller side after the call is connected. It must contain codes for two scenarios. Specify the codes in the order of &quot;A as callee and B as callee&quot;, separated by commas.</para>
        /// <remarks>
        /// <para>&quot;1,2&quot; indicates that the announcement code for the caller side when number A is the callee is 1, and the announcement code for the caller side when number B is the callee is 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>The number A of the landline AXN extension.</para>
        /// <remarks>
        /// <para>Number A can be set to a mobile phone number or a landline number. For a landline number, the area code must be included, and no hyphen is required between the area code and the number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mobile phone number: 182<b><b>2371
        /// Landline number: 0571</b></b>**36</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>The business timestamp. Format: yyyyMMddHHmmssSSS. The time is in UTC+8 and uses the 24-hour format, accurate to milliseconds.</para>
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
