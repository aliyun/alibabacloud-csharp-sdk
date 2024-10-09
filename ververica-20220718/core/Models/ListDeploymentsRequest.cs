// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListDeploymentsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user who creates the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668*******</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The execution mode of the deployment.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BATCH</description></item>
        /// <item><description>STREAMING</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STREAMING</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// <para>The tag value. Separate multiple values with semicolon (;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1,value2</para>
        /// </summary>
        [NameInMap("labelValueArray")]
        [Validation(Required=false)]
        public string LabelValueArray { get; set; }

        /// <summary>
        /// <para>The ID of the user who modifies the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668*******</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The name of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvp_ds_0522</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("sortName")]
        [Validation(Required=false)]
        public string SortName { get; set; }

        /// <summary>
        /// <para>The latest status of the deployment.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CANCELLED</description></item>
        /// <item><description>FAILED</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>TRANSITIONING</description></item>
        /// <item><description>FINISHED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
