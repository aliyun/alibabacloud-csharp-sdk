// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AnalyzeConversationRequest : TeaModel {
        /// <summary>
        /// <para>Call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-10963442671187****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>When the TaskListJson parameter is set to &quot;fields&quot;, this parameter specifies the field content to fetch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;code&quot;: &quot;OrderNo&quot;,
        ///     &quot;name&quot;: &quot;订单号&quot;,
        ///     &quot;description&quot;: &quot;订单号&quot;
        ///   },
        ///   {
        ///     &quot;code&quot;: &quot;ProductName&quot;,
        ///     &quot;name&quot;: &quot;商品名称&quot;,
        ///     &quot;description&quot;: &quot;商品名称&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("FieldListJson")]
        [Validation(Required=false)]
        public string FieldListJson { get; set; }

        /// <summary>
        /// <para>Cloud Contact Center instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9cfad875-6260-4a53-ab6e-b13e3fb31f7d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>List of Task Types for analysis. Valid values include:</para>
        /// <list type="bullet">
        /// <item><description><para>title: title</para>
        /// </description></item>
        /// <item><description><para>summary: summary</para>
        /// </description></item>
        /// <item><description><para>keywords: keywords</para>
        /// </description></item>
        /// <item><description><para>fields: fields</para>
        /// </description></item>
        /// </list>
        /// <para>Currently, only &quot;summary&quot; and &quot;title&quot; can be passed together. All other parameters must be passed individually.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;keywords&quot;]</para>
        /// </summary>
        [NameInMap("TaskListJson")]
        [Validation(Required=false)]
        public string TaskListJson { get; set; }

    }

}
