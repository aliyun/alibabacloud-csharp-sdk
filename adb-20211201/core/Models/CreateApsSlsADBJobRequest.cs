// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsSlsADBJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("AcrossRole")]
        [Validation(Required=false)]
        public string AcrossRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AcrossUid")]
        [Validation(Required=false)]
        public string AcrossUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AdvancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateApsSlsADBJobRequestColumns> Columns { get; set; }
        public class CreateApsSlsADBJobRequestColumns : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MapName")]
            [Validation(Required=false)]
            public string MapName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>int</para>
            /// </summary>
            [NameInMap("MapType")]
            [Validation(Required=false)]
            public string MapType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bigint</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-*********</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>327</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public long? DatasourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbName</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DirtyDataHandleMode")]
        [Validation(Required=false)]
        public string DirtyDataHandleMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STOP</para>
        /// </summary>
        [NameInMap("DirtyDataProcessPattern")]
        [Validation(Required=false)]
        public string DirtyDataProcessPattern { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExactlyOnce")]
        [Validation(Required=false)]
        public string ExactlyOnce { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("FullComputeUnit")]
        [Validation(Required=false)]
        public string FullComputeUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("HudiAdvancedConfig")]
        [Validation(Required=false)]
        public string HudiAdvancedConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>168</para>
        /// </summary>
        [NameInMap("IncrementalComputeUnit")]
        [Validation(Required=false)]
        public string IncrementalComputeUnit { get; set; }

        /// <summary>
        /// <para>lakehosue ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("LakehouseId")]
        [Validation(Required=false)]
        public long? LakehouseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("MaxOffsetsPerTrigger")]
        [Validation(Required=false)]
        public long? MaxOffsetsPerTrigger { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://test*</para>
        /// </summary>
        [NameInMap("OssLocation")]
        [Validation(Required=false)]
        public string OssLocation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PartitionSpecs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> PartitionSpecs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PrimaryKeyDefinition")]
        [Validation(Required=false)]
        public string PrimaryKeyDefinition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StartingOffsets")]
        [Validation(Required=false)]
        public string StartingOffsets { get; set; }

        /// <summary>
        /// <para>sls Store。</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Store")]
        [Validation(Required=false)]
        public string Store { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("TargetGenerateRule")]
        [Validation(Required=false)]
        public string TargetGenerateRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADB</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("UnixTimestampConvert")]
        [Validation(Required=false)]
        public CreateApsSlsADBJobRequestUnixTimestampConvert UnixTimestampConvert { get; set; }
        public class CreateApsSlsADBJobRequestUnixTimestampConvert : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false。</para>
            /// </summary>
            [NameInMap("Convert")]
            [Validation(Required=false)]
            public string Convert { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para> APSyyyyMMdd</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Transform")]
            [Validation(Required=false)]
            public bool? Transform { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-******</para>
        /// </summary>
        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

    }

}
