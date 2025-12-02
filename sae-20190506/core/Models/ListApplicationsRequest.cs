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
        /// <para>The SAE application type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>micro_service</b></description></item>
        /// <item><description><b>web</b></description></item>
        /// <item><description><b>job</b></description></item>
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
        /// <para>Set the filtering criteria for applications. The value options are as follows:</para>
        /// <list type="bullet">
        /// <item><description>appName: Application name.</description></item>
        /// <item><description>appIds: Application IDs.</description></item>
        /// <item><description>slbIps: SLB IP addresses.</description></item>
        /// <item><description>instanceIps: Instance IP addresses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>appName</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// <para>The name, ID, SLB IP, or instance IP of the target application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

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

        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <para>Specifies how applications are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b>: The applications are sorted based on the number of running instances.</description></item>
        /// <item><description><b>instances</b>: The applications are sorted based on the number of destination instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of records in each page. Value range: [0,10000]</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Sort by the running status of application instances. If the statuses are the same, sort by instance ID. The value options are as follows:</para>
        /// <list type="bullet">
        /// <item><description>true: Sort in ascending order. Instances are arranged according to the startup process, for example: to ultimately reach the running state, an instance must first go through steps such as starting containers, pulling images, and initializing the instance.</description></item>
        /// <item><description>false: Sort in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The tag in the format of a key-value pair.</para>
        /// <list type="bullet">
        /// <item><description><b>key</b>: the tag key. It cannot exceed 128 characters in length.</description></item>
        /// <item><description><b>value</b>: the tag value. It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// <para>Tag keys and tag values are case-sensitive. If you specify multiple tags, the system adds all the tags to the specified resources. Each tag key on a resource can have only one tag value. If you create a tag that has the same key as an existing tag, the value of the existing tag is overwritten.</para>
        /// <para>Tag keys and tag values cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;key&quot;,&quot;value&quot;:&quot;value&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
