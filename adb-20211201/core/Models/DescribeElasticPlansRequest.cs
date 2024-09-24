// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlansRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz9509beptiz****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the scaling plan.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, all scaling plans are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the scaling plans that are immediately enabled after the plans are created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the scaling plans of all resource groups are queried, covering the interactive resource group type and the elastic I/O unit (EIU) type.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/459446.html">DescribeDBResourceGroup</a> operation to query the name of a resource group within a cluster.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The type of the scaling plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EXECUTOR</b>: the interactive resource group type, which specifies the computing resource type.</description></item>
        /// <item><description><b>WORKER</b>: the EIU type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXECUTOR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
