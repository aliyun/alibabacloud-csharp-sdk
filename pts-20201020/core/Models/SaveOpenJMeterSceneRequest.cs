// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SaveOpenJMeterSceneRequest : TeaModel {
        /// <summary>
        /// <para>The details of the scenario.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenJMeterScene")]
        [Validation(Required=false)]
        public SaveOpenJMeterSceneRequestOpenJMeterScene OpenJMeterScene { get; set; }
        public class SaveOpenJMeterSceneRequestOpenJMeterScene : TeaModel {
            /// <summary>
            /// <para>The number of stress testers.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            /// <summary>
            /// <para>The maximum concurrency that is determined by the resource plans of users. You must configure this parameter when the mode is set to CONCURRENCY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>The type of the synchronization timer with fixed throughput in JMeter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL</para>
            /// </summary>
            [NameInMap("ConstantThroughputTimerType")]
            [Validation(Required=false)]
            public string ConstantThroughputTimerType { get; set; }

            /// <summary>
            /// <para>The settings of Domain Name System (DNS).</para>
            /// </summary>
            [NameInMap("DnsCacheConfig")]
            [Validation(Required=false)]
            public SaveOpenJMeterSceneRequestOpenJMeterSceneDnsCacheConfig DnsCacheConfig { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneDnsCacheConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to clear the cache in each iteration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ClearCacheEachIteration")]
                [Validation(Required=false)]
                public bool? ClearCacheEachIteration { get; set; }

                /// <summary>
                /// <para>The DNS servers.</para>
                /// </summary>
                [NameInMap("DnsServers")]
                [Validation(Required=false)]
                public List<string> DnsServers { get; set; }

                /// <summary>
                /// <para>The table that contains bound domain names.</para>
                /// </summary>
                [NameInMap("HostTable")]
                [Validation(Required=false)]
                public Dictionary<string, string> HostTable { get; set; }

            }

            /// <summary>
            /// <para>The stress testing duration. The maximum stress testing duration is no more than one day, Unit: seconds. Valid values: 60 to 86400.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the environment associated with the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I8PZIH</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The test files.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<SaveOpenJMeterSceneRequestOpenJMeterSceneFileList> FileList { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneFileList : TeaModel {
                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61232</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The name of the test file.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baidu.jmx</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) path that is used to access the test file over the Internet.</para>
                /// <remarks>
                /// <para> Only test files in the China (Shanghai) region can be accessed.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.cn-shanghai.aliyuncs.com/baidu.jmx">https://test.cn-shanghai.aliyuncs.com/baidu.jmx</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

                /// <summary>
                /// <para>The file size. The total file size cannot exceed 500 MB. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28880</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The MD5 hash of the test file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DA70F97A74D76B6A3BEF9CC8AE0D89EB</para>
                /// </summary>
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                /// <summary>
                /// <para>Specifies whether to split the test file. This parameter is valid only for CSV files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SplitCsv")]
                [Validation(Required=false)]
                public bool? SplitCsv { get; set; }

                /// <summary>
                /// <para>The file tag.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the test is a virtual private cloud (VPC) test. The default value is false, which indicates a public network test. VPC-related settings take effect only when you set this parameter to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsVpcTest")]
            [Validation(Required=false)]
            public bool? IsVpcTest { get; set; }

            /// <summary>
            /// <para>The JMeter properties.</para>
            /// </summary>
            [NameInMap("JMeterProperties")]
            [Validation(Required=false)]
            public List<SaveOpenJMeterSceneRequestOpenJMeterSceneJMeterProperties> JMeterProperties { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneJMeterProperties : TeaModel {
                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https.sessioncontext.shared</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The values of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The JMeter plug-in tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("JmeterPluginLabel")]
            [Validation(Required=false)]
            public string JmeterPluginLabel { get; set; }

            /// <summary>
            /// <para>The maximum RPS that takes effect in RPS mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxRps")]
            [Validation(Required=false)]
            public int? MaxRps { get; set; }

            /// <summary>
            /// <para>The stress model.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONCURRENCY</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The ramp-up period. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("RampUp")]
            [Validation(Required=false)]
            public int? RampUp { get; set; }

            /// <summary>
            /// <para>The region ID that is specified in the VPC test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The requirements for the regions of the stress testers.</para>
            /// </summary>
            [NameInMap("RegionalCondition")]
            [Validation(Required=false)]
            public List<SaveOpenJMeterSceneRequestOpenJMeterSceneRegionalCondition> RegionalCondition { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneRegionalCondition : TeaModel {
                /// <summary>
                /// <para>The number of stress tests. The sum of the number of stress tests in all regions must be equal to the AgentCount value of a specified scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The scenario ID. If you do not configure this parameter, the system creates a scenario. If you configure this parameter, the system updates the scenario corresponding to the ID specified by this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYYPZIH</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The security group ID that is specified in the VPC test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeid0dd7bhahsgdahspaly</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The initial concurrency that takes effect in concurrency mode. You must configure this parameter when the mode is set to CONCURRENCY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("StartConcurrency")]
            [Validation(Required=false)]
            public int? StartConcurrency { get; set; }

            /// <summary>
            /// <para>The initial RPS that takes effect in RPS mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("StartRps")]
            [Validation(Required=false)]
            public int? StartRps { get; set; }

            /// <summary>
            /// <para>The number of ramp-up steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public int? Steps { get; set; }

            /// <summary>
            /// <para>The type of the synchronization timer in JMeter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL</para>
            /// </summary>
            [NameInMap("SyncTimerType")]
            [Validation(Required=false)]
            public string SyncTimerType { get; set; }

            /// <summary>
            /// <para>The test file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baidu.jmx</para>
            /// </summary>
            [NameInMap("TestFile")]
            [Validation(Required=false)]
            public string TestFile { get; set; }

            /// <summary>
            /// <para>The vSwitch ID that is specified in the VPC test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zehsgdhsahw1r</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID that is specified in the VPC test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze2sahjdgahsebjkqhf4pyj</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
