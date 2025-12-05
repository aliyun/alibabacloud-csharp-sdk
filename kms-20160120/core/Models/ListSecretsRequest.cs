// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FetchTags")]
        [Validation(Required=false)]
        public string FetchTags { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;SecretName&quot;, &quot;Values&quot;:[&quot;Val1&quot;,&quot;Val2&quot;]}]</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The secret filter. The filter consists of one or more key-value pairs. You can specify one key-value pair or leave this parameter empty. If you use one tag key or tag value to filter resources, up to 4,000 resources can be queried. If you want to query more than 4,000 resources, call the <a href="https://help.aliyun.com/document_detail/120090.html">ListResourceTags</a> operation.</para>
        /// <list type="bullet">
        /// <item><description><para>Key</para>
        /// <list type="bullet">
        /// <item><description><para>Description: the property that you want to filter.</para>
        /// </description></item>
        /// <item><description><para>Type: string.</para>
        /// </description></item>
        /// <item><description><para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SecretName: the secret name.</description></item>
        /// <item><description>Description: the description of the secret.</description></item>
        /// <item><description>TagKey: the tag key.</description></item>
        /// <item><description>TagValue: the tag value.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Values</para>
        /// <list type="bullet">
        /// <item><description><para>Description: the value to be included after filtering.</para>
        /// </description></item>
        /// <item><description><para>Type: string.</para>
        /// </description></item>
        /// <item><description><para>Length: 0 to 10.</para>
        /// </description></item>
        /// <item><description><para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the Key field is set to SecretName, the value must be 1 to 192 characters in length and can contain letters, digits, and special characters <c>_ / + = . @ -</c>.</description></item>
        /// <item><description>If the Key field is set to Description, the value must be 1 to 256 characters in length.</description></item>
        /// <item><description>If the Key field is set to TagKey, the value must be 1 to 256 characters in length and can contain letters, digits, and special characters <c>/ _ - . + = @ :</c>.</description></item>
        /// <item><description>If the Key field is set to TagValue, the value must be 1 to 256 characters in length and can contain letters, numbers, and special characters <c>/ _ - . + = @ :</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The logical relationship between values of the Values field in a key-value pair is OR. Example: <c>[ {&quot;Key&quot;:&quot;SecretName&quot;, &quot;Values&quot;:[&quot;sec1&quot;,&quot;sec2&quot;]}]</c>. In this example, the semantics are <c>SecretName=sec 1 OR SecretName=sec 2</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
