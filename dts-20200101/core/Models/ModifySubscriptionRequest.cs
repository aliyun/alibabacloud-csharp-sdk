// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifySubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The modified subscription objects, in JSON format. For more information about the definition, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The new DbList value overwrites the original DbList value. Make sure that the new DbList value contains all the objects that you want to track. Otherwise, objects may be lost. Modify this parameter with caution.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/208925.html">DescribeDtsJobDetail</a> to query the original subscription objects.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsboss6pn1w******</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>boss6pn1w******</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the modified task subscribes to DDL data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The task subscribes to DDL data.</description></item>
        /// <item><description><b>false</b>: The task does not subscribe to DDL data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscriptionDataTypeDDL")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDDL { get; set; }

        /// <summary>
        /// <para>Specifies whether the modified task subscribes to DML data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The task subscribes to DML data.</description></item>
        /// <item><description><b>false</b>: The task does not subscribe to DML data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscriptionDataTypeDML")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDML { get; set; }

    }

}
