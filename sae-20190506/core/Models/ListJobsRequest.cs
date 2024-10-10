// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The parameter value is a positive integer that is greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The dimension by which applications are filtered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>appName</b>: Applications are filtered by job template name.</description></item>
        /// <item><description><b>appIds</b>: Applications are filtered by job template ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>appName</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// <para>Enter the name and ID of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-app</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

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
        /// <para>The number of entries to return on each page. Valid value: 0 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the field names that are passed by <b>OrderBy</b> in ascending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: in ascending order</description></item>
        /// <item><description><b>false</b>: in descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The tags that are displayed in a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>key</b>: the tag key</description></item>
        /// <item><description><b>value</b>: the tag value</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;key&quot;,&quot;value&quot;:&quot;value&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Set the value to <c>job</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("Workload")]
        [Validation(Required=false)]
        public string Workload { get; set; }

    }

}
