// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DTS dedicated cluster on which the task runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        [NameInMap("DestProductType")]
        [Validation(Required=false)]
        public string DestProductType { get; set; }

        /// <summary>
        /// <para>The environment tag of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b></description></item>
        /// <item><description><b>online</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsi03e3zty16i****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qa110wq5r93hb49</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the parent task.</para>
        /// <remarks>
        /// <para> In most cases, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pk13r731m****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The type of the DTS task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration. This is the default value.</description></item>
        /// <item><description><b>SYNC</b>: data synchronization.</description></item>
        /// <item><description><b>SUBSCRIBE</b>: change tracking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MIGRATION</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The basis on which the returned DTS tasks are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateTime</b>: sorts the DTS tasks based on the points in time when the DTS tasks are created.</description></item>
        /// <item><description><b>FinishTime</b>: sorts the DTS tasks based on the points in time when the DTS tasks are complete.</description></item>
        /// <item><description><b>duLimit</b> sorts the DTS tasks based on the upper limits on DTS Units (DUs) that the DTS tasks can use. This option applies only to the DTS tasks that are run on a DTS dedicated cluster.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can also set the <b>OrderDirection</b> parameter to specify whether to sort the DTS tasks in ascending or descending order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The order in which the returned DTS tasks are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: sorts the DTS tasks in ascending order. This is the default value.</description></item>
        /// <item><description><b>DESC</b>: sorts the DTS tasks in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than <b>0</b> and does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The content of the query condition.</para>
        /// <remarks>
        /// <para> You must set the <b>Type</b> parameter to specify the type of the query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtspk3f13r731m****</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SrcProductType")]
        [Validation(Required=false)]
        public string SrcProductType { get; set; }

        /// <summary>
        /// <para>The state of the DTS task.</para>
        /// <para>Valid values for a data migration task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>PreCheckPass</b>: The task passed the precheck.</description></item>
        /// <item><description><b>NotConfigured</b>: The task is not configured.</description></item>
        /// <item><description><b>Migrating</b>: The task is in progress.</description></item>
        /// <item><description><b>Suspending</b>: The task is paused.</description></item>
        /// <item><description><b>MigrationFailed</b>: The task failed.</description></item>
        /// <item><description><b>Finished</b>: The task is complete.</description></item>
        /// <item><description><b>Retrying</b>: The task is being retried.</description></item>
        /// <item><description><b>Upgrade</b>: The task is being upgraded.</description></item>
        /// <item><description><b>Locked</b>: The task is locked.</description></item>
        /// <item><description><b>Downgrade</b>: The task is being downgraded.</description></item>
        /// </list>
        /// <para>Valid values for a data synchronization task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>PreCheckPass</b>: The task passed the precheck.</description></item>
        /// <item><description><b>NotConfigured</b>: The task is not configured.</description></item>
        /// <item><description><b>Initializing</b>: The task is being initialized.</description></item>
        /// <item><description><b>InitializeFailed</b>: Initialization failed.</description></item>
        /// <item><description><b>Synchronizing</b>: The task is in progress.</description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// <item><description><b>Suspending</b>: The task is paused.</description></item>
        /// <item><description><b>Modifying</b>: The objects in the task are being modified.</description></item>
        /// <item><description><b>Finished</b>: The task is complete.</description></item>
        /// <item><description><b>Retrying</b>: The task is being retried.</description></item>
        /// <item><description><b>Upgrade</b>: The task is being upgraded.</description></item>
        /// <item><description><b>Locked</b>: The task is locked.</description></item>
        /// <item><description><b>Downgrade</b>: The task is being downgraded.</description></item>
        /// </list>
        /// <para>Valid values for a change tracking task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotConfigured</b>: The task is not configured.</description></item>
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>PreCheckPass</b>: The task passed the precheck.</description></item>
        /// <item><description><b>Starting</b>: The task is being started.</description></item>
        /// <item><description><b>Normal</b>: The task is running as expected.</description></item>
        /// <item><description><b>Retrying</b>: The task is being retried.</description></item>
        /// <item><description><b>Abnormal</b>: The task is not running as expected.</description></item>
        /// <item><description><b>Upgrade</b>: The task is being upgraded.</description></item>
        /// <item><description><b>Locked</b>: The task is locked.</description></item>
        /// <item><description><b>Downgrade</b>: The task is being downgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Migrating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the DTS task to be queried. Specify tags in the JSON format.</para>
        /// <remarks>
        /// <para> You can call the <b>ListTagResources</b> operation to query the tag key and tag value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[     {         \&quot;key\&quot;: \&quot;testK\&quot;,         \&quot;value\&quot;: \&quot;testV\&quot;     }  ]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The type of the query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: queries DTS tasks based on the ID of a DTS instance.</description></item>
        /// <item><description><b>name</b>: queries DTS tasks based on the name of a DTS instance. Fuzzy match is supported.</description></item>
        /// <item><description><b>srcRds</b>: queries DTS tasks based on the ID of an ApsaraDB RDS instance. The ApsaraDB RDS instance is the source instance of a DTS task.</description></item>
        /// <item><description><b>rds</b>: queries DTS tasks based on the ID of an ApsaraDB RDS instance. The ApsaraDB RDS instance is the destination instance of a DTS task.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must set the <b>Params</b> parameter to specify the content of the query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the <b>DbObject</b> parameter in the response. The DbObject parameter specifies the objects of the data migration, data synchronization, or change tracking task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: does not return <b>DbObject</b>.</description></item>
        /// <item><description><b>false</b>: returns <b>DbObject</b>. If you set this parameter to false, the response time is shortened.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithoutDbList")]
        [Validation(Required=false)]
        public bool? WithoutDbList { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
