// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeContact : TeaModel {
        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@company.com">zhangsan@company.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether the email address is authenticated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("emailVerify")]
        [Validation(Required=false)]
        public bool? EmailVerify { get; set; }

        /// <summary>
        /// <para>An extension field used to store additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;department&quot;: &quot;运维部&quot;, &quot;role&quot;: &quot;工程师&quot; }</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        /// <summary>
        /// <para>The time when the contact was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the contact was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The unique identifier of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The language preference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The country code for the mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("phoneCode")]
        [Validation(Required=false)]
        public string PhoneCode { get; set; }

        /// <summary>
        /// <para>Specifies whether the mobile phone number is authenticated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("phoneVerify")]
        [Validation(Required=false)]
        public bool? PhoneVerify { get; set; }

        /// <summary>
        /// <para>The source system of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
