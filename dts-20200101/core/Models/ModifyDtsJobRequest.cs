// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The <b>ClientToken</b> parameter can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full data migration or synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        /// <summary>
        /// <para>The objects of the data synchronization task after modification. The value must be a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The new value of DbList overwrites the original value. Make sure that all the objects that you want to synchronize are specified. Otherwise, some objects may be lost. Specify this parameter with caution.</para>
        /// </description></item>
        /// <item><description><para>Before you call the ModifyDtsJob operation, we recommend that you call the <a href="https://help.aliyun.com/document_detail/208925.html">DescribeDtsJobDetail</a> operation to query the current objects of the data synchronization task. Then, you can specify the new objects based on your business requirements. For example, if the current objects are Table A and Table B and you need to add Table C, you must specify Table A, Table B, and Table C for this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public Dictionary<string, object> DbList { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsbi6e22ay243****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The synchronization task ID. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fpx1149rw7p***</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The operator that is related to the extract, transform, and load (ETL) feature and dedicated to T+1 business.</para>
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
        /// <para>The endpoint of the Object Storage Service (OSS) bucket in which the files to be synchronized are stored.</para>
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
        /// <para>The method that is used to modify the data synchronization task. If you do not specify the parameter, the objects of the data synchronization task are modified by default. If you specify UPDATE_RESERVED for the parameter, the reserved parameters are modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE_RESERVED</para>
        /// </summary>
        [NameInMap("ModifyTypeEnum")]
        [Validation(Required=false)]
        public string ModifyTypeEnum { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the data synchronization instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved parameters of the data synchronization task. You can add reserved parameters instead of overwriting the existing reserved parameters. The value of the parameter is a MAP JSON string. You can specify this parameter to meet special requirements, such as specifying whether to automatically start the precheck of the data synchronization task. For more information, see <a href="https://help.aliyun.com/document_detail/176470.html">MigrationReserved</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;srcHostPorts\&quot;:\&quot;\&quot;,\&quot;whitelist.dms.online.ddl.enable\&quot;:false,\&quot;filterDDL\&quot;:false,\&quot;sqlparser.dms.original.ddl\&quot;:true,\&quot;srcOracleType\&quot;:\&quot;sid\&quot;,\&quot;maxRetryTime\&quot;:43200,\&quot;destSSL\&quot;:\&quot;0\&quot;,\&quot;destOracleType\&quot;:\&quot;sid\&quot;,\&quot;srcSSL\&quot;:\&quot;0\&quot;,\&quot;dbListCaseChangeMode\&quot;:\&quot;default\&quot;,\&quot;SourceEngineVersion\&quot;:\&quot;8.0.18\&quot;,\&quot;srcNetType\&quot;:\&quot;VPC\&quot;,\&quot;destNetType\&quot;:\&quot;VPC\&quot;,\&quot;srcVpcNetMappingInst\&quot;:\&quot;172.16.1**.<b>:10803\&quot;,\&quot;destVpcNetMappingInst\&quot;:\&quot;172.16.1</b>.**:11077\&quot;,\&quot;useJobTask\&quot;:\&quot;1\&quot;}</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform schema migration or synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>Forward</b>: Data is synchronized from the source database to the destination database.</description></item>
        /// <item><description><b>Reverse</b>: Data is synchronized from the destination database to the source database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// <item><description>This parameter is required only if the topology of the data synchronization instance is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>Whether it is a seamless integration (Zero-ETL) task, the value can be:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No. - <b>true</b>: Yes.</description></item>
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
