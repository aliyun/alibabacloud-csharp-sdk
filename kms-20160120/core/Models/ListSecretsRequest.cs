// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return resource tags for each secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Resource tags are returned.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (default): Resource tags are not returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FetchTags")]
        [Validation(Required=false)]
        public string FetchTags { get; set; }

        /// <summary>
        /// <para>Filters secrets based on specified conditions. The value is a list of up to 10 key-value pairs. When you filter by tag, the query returns a maximum of 4,000 resources. If more than 4,000 resources match the filter, call the <a href="https://help.aliyun.com/document_detail/120090.html">ListResourceTags</a> operation.</para>
        /// <list type="bullet">
        /// <item><description><para>Key</para>
        /// <list type="bullet">
        /// <item><description><para>Description: The filter property.</para>
        /// </description></item>
        /// <item><description><para>Type: String.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Values</para>
        /// <list type="bullet">
        /// <item><description><para>Description: The filter value.</para>
        /// </description></item>
        /// <item><description><para>Type: String.</para>
        /// </description></item>
        /// <item><description><para>You can specify up to 10 items.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Valid values for Key:</para>
        /// <list type="bullet">
        /// <item><description><para>Set <c>Key</c> to <b>SecretName</b> to filter by secret name.</para>
        /// </description></item>
        /// <item><description><para>Set <c>Key</c> to <b>Description</b> to filter by secret description.</para>
        /// </description></item>
        /// <item><description><para>Set <c>Key</c> to <b>TagKey</b> to filter by tag key.</para>
        /// </description></item>
        /// <item><description><para>Set <c>Key</c> to <b>TagValue</b> to filter by tag value.</para>
        /// </description></item>
        /// <item><description><para>Set <c>Key</c> to <b>DKMSInstanceId</b> to filter by KMS instance ID.</para>
        /// </description></item>
        /// <item><description><para>Set Key to <b>SecretType</b> to filter by secret type. <c>Values</c> can be <c>Generic</c>, <c>RDS</c>, <c>Redis</c>, <c>RAMCredentials</c>, <c>ECS</c>, or <c>PolarDB</c>.</para>
        /// </description></item>
        /// <item><description><para>Set <c>Key</c> to <b>Creator</b> to filter by the creator of the secret.</para>
        /// </description></item>
        /// </list>
        /// <para>If you specify multiple values for a key, the filter applies a logical OR. For example, if you enter <c>[ {&quot;Key&quot;:&quot;SecretName&quot;, &quot;Values&quot;:[&quot;sec1&quot;,&quot;sec2&quot;]} ]</c>, this means: <c>(SecretName=sec1 OR SecretName=sec2)</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;SecretName&quot;, &quot;Values&quot;:[&quot;Val1&quot;,&quot;Val2&quot;]}]</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The page number.<br>
        /// The value must be greater than 0.<br>
        /// Default: 1.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.<br>
        /// The value must be between 1 and 100.<br>
        /// Default: 10.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
