// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The type of the SAE application.</para>
        /// <list type="bullet">
        /// <item><description><para><b>micro_service</b></para>
        /// </description></item>
        /// <item><description><para><b>web</b></para>
        /// </description></item>
        /// <item><description><para><b>job</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>micro_service</para>
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The field to filter applications by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>appName</b>: The application name.</para>
        /// </description></item>
        /// <item><description><para><b>appIds</b>: The application ID.</para>
        /// </description></item>
        /// <item><description><para><b>slbIps</b>: The SLB IP address.</para>
        /// </description></item>
        /// <item><description><para><b>instanceIps</b>: The instance IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>appName</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// <para>The value for the field specified by <c>FieldType</c>. This can be an application name, application ID, SLB IP address, or instance IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>Filters applications by whether they are stateful. Set this parameter to <c>true</c> to return only stateful applications, or to <c>false</c> to return only stateless applications.</para>
        /// </summary>
        [NameInMap("IsStateful")]
        [Validation(Required=false)]
        public string IsStateful { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:demo</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The edition of the application:</para>
        /// <list type="bullet">
        /// <item><description><para><c>lite</c>: Lite</para>
        /// </description></item>
        /// <item><description><para><c>std</c>: Standard</para>
        /// </description></item>
        /// <item><description><para><c>pro</c>: Pro</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <para>The field to sort the applications by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>runnings</b>: Sorts the applications by the current instance count.</para>
        /// </description></item>
        /// <item><description><para><b>instances</b>: Sorts the applications by the target instance count.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>runnings</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: 0 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sorts the results in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Sorts the results in descending order.</para>
        /// </description></item>
        /// </list>
        /// <ol>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// <item><description><hr>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>Filters applications by tags. The tags are specified as a JSON string that contains an array of key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><para><b>key</b>: The tag key, which can be 1 to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The tag value, which can be 1 to 128 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is case-sensitive. An application is returned only if it matches all specified tags. On a resource, a tag key can have only one tag value.</para>
        /// <para>The tag key and tag value cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;key&quot;,&quot;value&quot;:&quot;value&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
