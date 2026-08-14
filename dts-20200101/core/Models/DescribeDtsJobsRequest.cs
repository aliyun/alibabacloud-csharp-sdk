// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DTS dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The type of the source database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("DestProductType")]
        [Validation(Required=false)]
        public string DestProductType { get; set; }

        /// <summary>
        /// <para>The environment label of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: normal</description></item>
        /// <item><description><b>online</b>: online</description></item>
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
        /// <remarks>
        /// <para>Separate multiple instance IDs with commas (,). Make sure that the <b>JobType</b> parameter is set as expected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsi03e3zty16i****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// <remarks>
        /// <para>Separate multiple task IDs with commas (,). Make sure that the <b>JobType</b> parameter is set as expected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>qa110wq5r93hb49</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The DTS task ID.</para>
        /// <remarks>
        /// <para>In most cases, you do not need to set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pk13r731m****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the source or destination database instance that corresponds to the <b>InstanceType</b> request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1966yuut4w3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the source or destination database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The task type of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration (default).</description></item>
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
        /// <para>The sort criterion when the response contains multiple DTS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateTime</b>: sorts by task creation time.</description></item>
        /// <item><description><b>FinishTime</b>: sorts by task completion time.</description></item>
        /// <item><description><b>duLimit</b> (dedicated cluster tasks): sorts by the upper limit of DU usage for DTS tasks. This value is supported only for dedicated clusters.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can also specify <b>OrderDirection</b> to set the sort order to ascending or descending.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The sort order of instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: ascending order. This is the default value.</description></item>
        /// <item><description><b>DESC</b>: descending order.</description></item>
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
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: <b>10</b>, <b>20</b>, and <b>30</b>. Default value: <b>20</b>. Maximum value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The specific content of the query condition.</para>
        /// <remarks>
        /// <para>Specify <b>Type</b> in advance to define the query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtspk3f13r731m****</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Deprecated parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
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

        /// <summary>
        /// <para>The type of the destination database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("SrcProductType")]
        [Validation(Required=false)]
        public string SrcProductType { get; set; }

        /// <summary>
        /// <para>The instance status of the DTS instance. Valid values:</para>
        /// <para>Data migration task statuses:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running a precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: precheck failed.</description></item>
        /// <item><description><b>PreCheckPass</b>: precheck passed.</description></item>
        /// <item><description><b>NotConfigured</b>: not configured.</description></item>
        /// <item><description><b>Migrating</b>: migrating.</description></item>
        /// <item><description><b>Suspending</b>: paused.</description></item>
        /// <item><description><b>MigrationFailed</b>: migration failed.</description></item>
        /// <item><description><b>Finished</b>: completed.</description></item>
        /// <item><description><b>Retrying</b>: retrying.</description></item>
        /// <item><description><b>Upgrade</b>: upgrading.</description></item>
        /// <item><description><b>Locked</b>: locked.</description></item>
        /// <item><description><b>Downgrade</b>: downgrading.</description></item>
        /// </list>
        /// <para>Data synchronization task statuses:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running a precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: precheck failed.</description></item>
        /// <item><description><b>PreCheckPass</b>: precheck passed.</description></item>
        /// <item><description><b>NotConfigured</b>: not configured.</description></item>
        /// <item><description><b>Initializing</b>: performing initial synchronization.</description></item>
        /// <item><description><b>InitializeFailed</b>: initial synchronization failed.</description></item>
        /// <item><description><b>Synchronizing</b>: synchronizing.</description></item>
        /// <item><description><b>Failed</b>: synchronization failed.</description></item>
        /// <item><description><b>Suspending</b>: paused.</description></item>
        /// <item><description><b>Modifying</b>: modifying synchronization objects.</description></item>
        /// <item><description><b>Finished</b>: completed.</description></item>
        /// <item><description><b>Retrying</b>: retrying.</description></item>
        /// <item><description><b>Upgrade</b>: upgrading.</description></item>
        /// <item><description><b>Locked</b>: locked.</description></item>
        /// <item><description><b>Downgrade</b>: downgrading.</description></item>
        /// </list>
        /// <para>Change tracking task statuses:</para>
        /// <list type="bullet">
        /// <item><description><b>NotConfigured</b>: not configured.</description></item>
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running a precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: precheck failed.</description></item>
        /// <item><description><b>PreCheckPass</b>: precheck passed.</description></item>
        /// <item><description><b>Starting</b>: starting.</description></item>
        /// <item><description><b>Normal</b>: normal.</description></item>
        /// <item><description><b>Retrying</b>: retrying.</description></item>
        /// <item><description><b>Abnormal</b>: abnormal.</description></item>
        /// <item><description><b>Upgrade</b>: upgrading.</description></item>
        /// <item><description><b>Locked</b>: locked.</description></item>
        /// <item><description><b>Downgrade</b>: downgrading.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Migrating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag-based search condition in JSON format.</para>
        /// <remarks>
        /// <para>You can call the <b>ListTagResources</b> operation to query tag keys and values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[     {         \&quot;key\&quot;: \&quot;testK\&quot;,         \&quot;value\&quot;: \&quot;testV\&quot;     }  ]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The conditional query parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: queries by DTS instance ID.</description></item>
        /// <item><description><b>name</b>: queries by DTS instance name. Fuzzy match is supported.</description></item>
        /// <item><description><b>srcRds</b>: queries by the ID of the source instance (ApsaraDB RDS).</description></item>
        /// <item><description><b>rds</b>: queries by the ID of the destination instance (ApsaraDB RDS).</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify the <b>Params</b> parameter to provide the specific content of the query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude task objects from the response (not return the <b>DbObject</b> parameter). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: excludes <b>DbObject</b> from the response.</description></item>
        /// <item><description><b>false</b>: includes <b>DbObject</b> in the response, which can improve the response speed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithoutDbList")]
        [Validation(Required=false)]
        public bool? WithoutDbList { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (Zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No.</description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
