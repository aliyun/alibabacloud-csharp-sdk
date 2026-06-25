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
        /// <para>The page number. The value starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The dimension by which to filter job templates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>appName</b>: The name of the job template.</para>
        /// </description></item>
        /// <item><description><para><b>appIds</b>: The ID of the job template.</para>
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
        /// <para>The name or ID of the target job template. This value corresponds to the dimension specified by <b>FieldType</b>.</para>
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
        /// <para>The sorting method for the job templates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>running</b>: Sorts by the number of running instances.</para>
        /// </description></item>
        /// <item><description><para><b>instances</b>: Sorts by the number of destination instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 0 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the results in ascending or descending order based on the field specified by the <b>OrderBy</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>A list of tags. This is a JSON string. The value consists of the following parts:</para>
        /// <list type="bullet">
        /// <item><description><para><b>key</b>: The tag key.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The tag value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;key&quot;,&quot;value&quot;:&quot;value&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The workload. Set the value to <c>job</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("Workload")]
        [Validation(Required=false)]
        public string Workload { get; set; }

    }

}
