// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full data migration or initial full data synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform incremental data migration or synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: no.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        /// <summary>
        /// <para>The modified synchronization objects, in JSON format. For more information about the definition, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// <list type="bullet">
        /// <item><description>The original DbList is overwritten by the new DbList. Make sure that the new DbList contains all the objects that need to be synchronized. Otherwise, synchronization objects may be lost. Modify this parameter with caution.</description></item>
        /// <item><description>Call <a href="https://help.aliyun.com/document_detail/208925.html">DescribeDtsJobDetail</a> to query the current synchronization objects before you modify them based on your business requirements. For example, if the current objects are tables A and B, and you want to add table C, specify tables A, B, and C in this parameter.</description></item>
        /// <item><description>The maximum size of DbList is 1 MB.</description></item>
        /// <item><description>If DbList contains filter conditions, the total length of DbList (including filter conditions) cannot exceed 1 MB.</description></item>
        /// <item><description>For distributed tasks (such as migration or synchronization tasks whose source is PolarDB-X 1.0), DbList is split based on physical shards and multiple subtasks are generated. The maximum size of DbList for each subtask is 1 MB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public Dictionary<string, object> DbList { get; set; }

        /// <summary>
        /// <para>The instance ID of the data synchronization instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsbi6e22ay243****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fpx1149rw7p***</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>A field dedicated to T+1 business scenarios. This is an ETL operator and a business-specific field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;configKeyMap&quot;: [
        ///     {
        ///       &quot;moduleCode&quot;: &quot;03&quot;,
        ///       &quot;etlOperatorColumnReference&quot;: &quot;etlOperatorColumnReference&quot;,
        ///       &quot;etlOperatorSetting&quot;: &quot;etlOperatorSetting&quot;
        ///     },
        ///     {
        ///       &quot;moduleCode&quot;: &quot;07&quot;,
        ///       &quot;etlOperatorColumnReference&quot;: &quot;etlOperatorColumnReference&quot;,
        ///       &quot;etlOperatorSetting&quot;: &quot;etlOperatorSetting&quot;
        ///     }
        ///   ],
        ///   &quot;amp.increment.replicator.compare.all.columns.enable&quot;: false,
        ///   &quot;srcNetType&quot;: &quot;VPC&quot;,
        ///   &quot;etlOperatorColumnReference&quot;: {
        ///     &quot;MODIFY_TIME&quot;: [
        ///       {
        ///         &quot;datasynchron.test_timing_user_000&quot;: &quot;user_create_date&quot;
        ///       },
        ///       {
        ///         &quot;datasynchron.test_timing_user_001&quot;: &quot;user_create_date&quot;
        ///       },
        ///       {
        ///         &quot;datasynchron.test_timing_user_002&quot;: &quot;user_create_date&quot;
        ///       },
        ///       {
        ///         &quot;datasynchron.test_timing_user_003&quot;: &quot;user_create_date&quot;
        ///       }
        ///     ]
        ///   },
        ///   &quot;destNetType&quot;: &quot;VPC&quot;,
        ///   &quot;originalSrcDbInst&quot;: &quot;sg-sit-db2-primary.mysql.polardb.rds.aliyuncs.com&quot;,
        ///   &quot;etlOperatorSetting&quot;: &quot;adb_time_travel&quot;,
        ///   &quot;sjobUseJobTask&quot;: &quot;1&quot;,
        ///   &quot;srcVpcNetMappingInst&quot;: &quot;172.19.XXX.XXX:4261&quot;,
        ///   &quot;destVpcNetMappingInst&quot;: &quot;172.19.XXX.XXX:4260&quot;,
        ///   &quot;useJobTask&quot;: &quot;1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("EtlOperatorColumnReference")]
        [Validation(Required=false)]
        public string EtlOperatorColumnReference { get; set; }

        /// <summary>
        /// <para>The OSS URL of the synchronization file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_12185******43989">http://db-list-os-file.oss-cn-shanghai.aliyuncs.com/8e42_12185******43989</a>_************</para>
        /// </summary>
        [NameInMap("FileOssUrl")]
        [Validation(Required=false)]
        public string FileOssUrl { get; set; }

        /// <summary>
        /// <para>The name of the table to be filtered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtable</para>
        /// </summary>
        [NameInMap("FilterTableName")]
        [Validation(Required=false)]
        public string FilterTableName { get; set; }

        /// <summary>
        /// <para>The method used to modify the synchronization task. If this parameter is not specified, the synchronization objects are modified by default. Set this parameter to UPDATE_RESERVED to modify reserved parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE_RESERVED</para>
        /// </summary>
        [NameInMap("ModifyTypeEnum")]
        [Validation(Required=false)]
        public string ModifyTypeEnum { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved parameters of DTS. The update method is append rather than overwrite. The value is in the MAP JSON format. You can specify this parameter to meet special requirements, such as whether to automatically start a precheck. The usage is similar to that of the Reserve parameter. For details, see <a href="https://help.aliyun.com/document_detail/273111.html">Reserve parameter description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;definer&quot;: false,&quot;syncArchitecture&quot;: &quot;oneway&quot;,&quot;whitelist.dms.online.ddl.enable&quot;: false,&quot;destSSL&quot;: &quot;0&quot;,&quot;triggerMode&quot;: &quot;manual&quot;,&quot;sqlparser.dms.original.ddl&quot;: true,&quot;whitelist.ghost.online.ddl.enable&quot;: false,&quot;privilegeMigration&quot;: false,&quot;maxRetryTime&quot;: 43200,&quot;srcSSL&quot;: &quot;0&quot;,&quot;autoStartModulesAfterConfig&quot;: &quot;none&quot;}</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

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
        /// <para>Specifies whether to perform schema migration or initial schema synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only when the synchronization topology of the data synchronization instance is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>Specifies whether this is a seamless integration (zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
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
