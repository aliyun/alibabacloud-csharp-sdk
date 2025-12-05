// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetOpenJMeterSceneResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. If the operation is successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E16480-15C1-555A-922F-B736A005E52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the scenario.</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public GetOpenJMeterSceneResponseBodyScene Scene { get; set; }
        public class GetOpenJMeterSceneResponseBodyScene : TeaModel {
            /// <summary>
            /// <para>The number of load generators. A load generator supports up to 500 concurrent virtual users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            /// <summary>
            /// <para>The basic information.</para>
            /// </summary>
            [NameInMap("BaseInfo")]
            [Validation(Required=false)]
            public GetOpenJMeterSceneResponseBodySceneBaseInfo BaseInfo { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneBaseInfo : TeaModel {
                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("CreateName")]
                [Validation(Required=false)]
                public string CreateName { get; set; }

                /// <summary>
                /// <para>The name of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>里斯</para>
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

                /// <summary>
                /// <para>The type of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>保存去压测</para>
                /// </summary>
                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                /// <summary>
                /// <para>The person who takes charge of the performance testing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-person</para>
                /// </summary>
                [NameInMap("Principal")]
                [Validation(Required=false)]
                public string Principal { get; set; }

                /// <summary>
                /// <para>The comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>小心压测</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The origin of the scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of concurrent virtual users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>The type of the constant throughput timer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STAND_ALONE</para>
            /// </summary>
            [NameInMap("ConstantThroughputTimerType")]
            [Validation(Required=false)]
            public string ConstantThroughputTimerType { get; set; }

            /// <summary>
            /// <para>The DNS settings.</para>
            /// </summary>
            [NameInMap("DnsCacheConfig")]
            [Validation(Required=false)]
            public GetOpenJMeterSceneResponseBodySceneDnsCacheConfig DnsCacheConfig { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneDnsCacheConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the cache is cleared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ClearCacheEachIteration")]
                [Validation(Required=false)]
                public bool? ClearCacheEachIteration { get; set; }

                /// <summary>
                /// <para>The DNS servers</para>
                /// </summary>
                [NameInMap("DnsServers")]
                [Validation(Required=false)]
                public List<string> DnsServers { get; set; }

                /// <summary>
                /// <para>The domain name and its bounded IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;server.com&quot;:&quot;6.6.6.6&quot;}</para>
                /// </summary>
                [NameInMap("HostTable")]
                [Validation(Required=false)]
                public Dictionary<string, object> HostTable { get; set; }

            }

            /// <summary>
            /// <para>The duration of the performance testing. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EEDT7</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The files.</para>
            /// </summary>
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<GetOpenJMeterSceneResponseBodySceneFileList> FileList { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneFileList : TeaModel {
                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>json.jar</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) URL of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/json.jar">https://test.oss-cn-shanghai.aliyuncs.com/json.jar</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

                /// <summary>
                /// <para>The size of the file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>700</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The type of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jar</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61660</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The MD5 value of the JAR package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43B584026CE5E570F3DE638FA7EEF9E0</para>
                /// </summary>
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                /// <summary>
                /// <para>Indicates whether the file is split.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SplitCsv")]
                [Validation(Required=false)]
                public bool? SplitCsv { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the load is from a virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVpcTest")]
            [Validation(Required=false)]
            public bool? IsVpcTest { get; set; }

            /// <summary>
            /// <para>The maximum RPS. This parameter is returned if you set Mode to tps_mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MaxRps")]
            [Validation(Required=false)]
            public int? MaxRps { get; set; }

            /// <summary>
            /// <para>The load application mode. Valid values: concurrency_mode and tps_mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>concurrency_mode</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The origin of the load. &quot;&quot; indicates the Internet and intranet-vpc indicates the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Pool")]
            [Validation(Required=false)]
            public string Pool { get; set; }

            /// <summary>
            /// <para>The period of time during which the load is gradually increased to the desired level. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RampUp")]
            [Validation(Required=false)]
            public int? RampUp { get; set; }

            /// <summary>
            /// <para>The region ID. This parameter is returned if the load is from a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Customized load generator settings for regions</para>
            /// </summary>
            [NameInMap("RegionalCondition")]
            [Validation(Required=false)]
            public List<GetOpenJMeterSceneResponseBodySceneRegionalCondition> RegionalCondition { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneRegionalCondition : TeaModel {
                /// <summary>
                /// <para>The number of load generators.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The ID of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYYPZIH</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The name of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The ID of the security group. This parameter is returned if the load is from a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeid0dd7bhahsgdahspaly</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The start number of concurrent virtual users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StartConcurrency")]
            [Validation(Required=false)]
            public int? StartConcurrency { get; set; }

            /// <summary>
            /// <para>The start requests per second (RPS). This parameter is returned if you set Mode to tps_mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StartRps")]
            [Validation(Required=false)]
            public int? StartRps { get; set; }

            /// <summary>
            /// <para>The number of incremented users per step. If RampUp or Steps is not specified, the fixed load is used. If RampUp is specified but Steps is not specified, the load increases uniformly based on the value of RampUp. If RampUp and Steps are specified and Steps is less than RampUp, the load increases based on the value of Steps. You cannot specify Steps without specifying RampUp. If you do so, the fixed load is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public int? Steps { get; set; }

            /// <summary>
            /// <para>The type of the synchronization timer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL</para>
            /// </summary>
            [NameInMap("SyncTimerType")]
            [Validation(Required=false)]
            public string SyncTimerType { get; set; }

            /// <summary>
            /// <para>The test file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baidu.jmx</para>
            /// </summary>
            [NameInMap("TestFile")]
            [Validation(Required=false)]
            public string TestFile { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch. This parameter is returned if the load is from a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zehsgdhsahw1r</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC. This parameter is returned if the load is from a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze2sahjdgahsebjkqhf4pyj</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
