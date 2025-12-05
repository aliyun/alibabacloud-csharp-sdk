// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetRandomPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The characters that are not included in the password to be generated.</para>
        /// <para>Valid values:</para>
        /// <para><c>Valid characters: 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ! \\&quot;#$%&amp;\\&quot;()*+,-. /:;&lt;=&gt;? @[\\] your_project_id} ~ </c>.</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCabc</para>
        /// </summary>
        [NameInMap("ExcludeCharacters")]
        [Validation(Required=false)]
        public string ExcludeCharacters { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude lowercase letters.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludeLowercase")]
        [Validation(Required=false)]
        public string ExcludeLowercase { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude digits.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludeNumbers")]
        [Validation(Required=false)]
        public string ExcludeNumbers { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude special characters.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludePunctuation")]
        [Validation(Required=false)]
        public string ExcludePunctuation { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude uppercase letters.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludeUppercase")]
        [Validation(Required=false)]
        public string ExcludeUppercase { get; set; }

        /// <summary>
        /// <para>The number of bytes that the password to be generated contains.</para>
        /// <para>Valid values: 8 to 128.</para>
        /// <para>Default value: 32</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("PasswordLength")]
        [Validation(Required=false)]
        public string PasswordLength { get; set; }

        /// <summary>
        /// <para>Specifies whether to include all the preceding character types.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequireEachIncludedType")]
        [Validation(Required=false)]
        public string RequireEachIncludedType { get; set; }

    }

}
