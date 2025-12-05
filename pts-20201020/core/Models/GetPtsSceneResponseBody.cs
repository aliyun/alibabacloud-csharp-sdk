// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneResponseBody : TeaModel {
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
        /// <para>The error message. If the operation is successful, N/A is returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E3177-6745-4925-B423-4E89VV34221A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The structure of the scenario.</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public GetPtsSceneResponseBodyScene Scene { get; set; }
        public class GetPtsSceneResponseBodyScene : TeaModel {
            /// <summary>
            /// <para>The advanced settings.</para>
            /// </summary>
            [NameInMap("AdvanceSetting")]
            [Validation(Required=false)]
            public GetPtsSceneResponseBodySceneAdvanceSetting AdvanceSetting { get; set; }
            public class GetPtsSceneResponseBodySceneAdvanceSetting : TeaModel {
                /// <summary>
                /// <para>The timeout period of the scenario. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConnectionTimeoutInSecond")]
                [Validation(Required=false)]
                public int? ConnectionTimeoutInSecond { get; set; }

                /// <summary>
                /// <para>The IP-domain name bindings.</para>
                /// </summary>
                [NameInMap("DomainBindingList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneAdvanceSettingDomainBindingList> DomainBindingList { get; set; }
                public class GetPtsSceneResponseBodySceneAdvanceSettingDomainBindingList : TeaModel {
                    /// <summary>
                    /// <para>The domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>The IPs bound to the domain name.</para>
                    /// </summary>
                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                /// <summary>
                /// <para>The log sampling rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LogRate")]
                [Validation(Required=false)]
                public int? LogRate { get; set; }

                /// <summary>
                /// <para>The custom success code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>429,304</para>
                /// </summary>
                [NameInMap("SuccessCode")]
                [Validation(Required=false)]
                public string SuccessCode { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-26 15:30:30</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The file parameters.</para>
            /// </summary>
            [NameInMap("FileParameterList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneFileParameterList> FileParameterList { get; set; }
            public class GetPtsSceneResponseBodySceneFileParameterList : TeaModel {
                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city.csv</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The OSS address of the file. Make sure that the address is accessible from the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/json.jar">https://test.oss-cn-shanghai.aliyuncs.com/json.jar</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

            }

            /// <summary>
            /// <para>Global parameters</para>
            /// </summary>
            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneGlobalParameterList> GlobalParameterList { get; set; }
            public class GetPtsSceneResponseBodySceneGlobalParameterList : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userName</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lisi</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// <para>The global headers for the scenario.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneHeaders> Headers { get; set; }
            public class GetPtsSceneResponseBodySceneHeaders : TeaModel {
                /// <summary>
                /// <para>The name of the header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The load settings.</para>
            /// </summary>
            [NameInMap("LoadConfig")]
            [Validation(Required=false)]
            public GetPtsSceneResponseBodySceneLoadConfig LoadConfig { get; set; }
            public class GetPtsSceneResponseBodySceneLoadConfig : TeaModel {
                /// <summary>
                /// <para>The number of load generators.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentCount")]
                [Validation(Required=false)]
                public int? AgentCount { get; set; }

                /// <summary>
                /// <para>The API request load settings.</para>
                /// </summary>
                [NameInMap("ApiLoadConfigList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneLoadConfigApiLoadConfigList> ApiLoadConfigList { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigApiLoadConfigList : TeaModel {
                    /// <summary>
                    /// <para>The API ID. You can track an API by its ID in sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GBFDCV8</para>
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The starting requests per second (RPS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("RpsBegin")]
                    [Validation(Required=false)]
                    public int? RpsBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum RPS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the load is automatically incremented.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoStep")]
                [Validation(Required=false)]
                public bool? AutoStep { get; set; }

                /// <summary>
                /// <para>The concurrency and RPS settings of the scenario.</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public GetPtsSceneResponseBodySceneLoadConfigConfiguration Configuration { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The starting number of concurrent sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("AllConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyLimit { get; set; }

                    /// <summary>
                    /// <para>The starting RPS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllRpsBegin")]
                    [Validation(Required=false)]
                    public int? AllRpsBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum RPS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("AllRpsLimit")]
                    [Validation(Required=false)]
                    public int? AllRpsLimit { get; set; }

                }

                /// <summary>
                /// <para>The increment percentage. The valid values are 10 to 100, in increments of 10. This parameter is returned only if you set testMode to concurrency_mode and set autoStep to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Increment")]
                [Validation(Required=false)]
                public int? Increment { get; set; }

                /// <summary>
                /// <para>The duration during which a specific load level is applied. The duration is less than the value of maxRunningTime. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("KeepTime")]
                [Validation(Required=false)]
                public int? KeepTime { get; set; }

                /// <summary>
                /// <para>The maximum duration of load application. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxRunningTime")]
                [Validation(Required=false)]
                public int? MaxRunningTime { get; set; }

                /// <summary>
                /// <para>The session load settings.</para>
                /// </summary>
                [NameInMap("RelationLoadConfigList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneLoadConfigRelationLoadConfigList> RelationLoadConfigList { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigRelationLoadConfigList : TeaModel {
                    /// <summary>
                    /// <para>The starting number of concurrent sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? ConcurrencyBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("ConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? ConcurrencyLimit { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HNBGS7M</para>
                    /// </summary>
                    [NameInMap("RelationId")]
                    [Validation(Required=false)]
                    public string RelationId { get; set; }

                }

                /// <summary>
                /// <para>The load application mode. Transactions per second (TPS) indicates the RPS mode.</para>
                /// <remarks>
                /// <para> The load application mode is CONCURRENCY/TPS.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>TPS</para>
                /// </summary>
                [NameInMap("TestMode")]
                [Validation(Required=false)]
                public string TestMode { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) settings. This information is returned only if you set the testing mode to VPC.</para>
                /// </summary>
                [NameInMap("VpcLoadConfig")]
                [Validation(Required=false)]
                public GetPtsSceneResponseBodySceneLoadConfigVpcLoadConfig VpcLoadConfig { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigVpcLoadConfig : TeaModel {
                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-jkasgfieiajidsjakjscb</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-skjfhlahsljkhsfalkjdoiw</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-akjhsdajgjsfggahjkga</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The last modification time of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-26 15:30:30</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The sessions.</para>
            /// </summary>
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneRelationList> RelationList { get; set; }
            public class GetPtsSceneResponseBodySceneRelationList : TeaModel {
                /// <summary>
                /// <para>The APIs.</para>
                /// </summary>
                [NameInMap("ApiList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneRelationListApiList> ApiList { get; set; }
                public class GetPtsSceneResponseBodySceneRelationListApiList : TeaModel {
                    /// <summary>
                    /// <para>The API ID. You can track an API by its ID in sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GBFDCV8</para>
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The API name.</para>
                    /// </summary>
                    [NameInMap("ApiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <para>The request body.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetPtsSceneResponseBodySceneRelationListApiListBody Body { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListBody : TeaModel {
                        /// <summary>
                        /// <para>The body value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{\&quot;key1\&quot;:\&quot;111\&quot;,\&quot;key2\&quot;:\&quot;222\&quot;}</para>
                        /// </summary>
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        /// <summary>
                        /// <para>The body type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>application/x-www-form-urlencoded</para>
                        /// </summary>
                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    /// <summary>
                    /// <para>The checkpoints.</para>
                    /// </summary>
                    [NameInMap("CheckPointList")]
                    [Validation(Required=false)]
                    public List<GetPtsSceneResponseBodySceneRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListCheckPointList : TeaModel {
                        /// <summary>
                        /// <para>The checked parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userId</para>
                        /// </summary>
                        [NameInMap("CheckPoint")]
                        [Validation(Required=false)]
                        public string CheckPoint { get; set; }

                        /// <summary>
                        /// <para>The check type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXPORTED_PARAM</para>
                        /// </summary>
                        [NameInMap("CheckType")]
                        [Validation(Required=false)]
                        public string CheckType { get; set; }

                        /// <summary>
                        /// <para>The expected value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>111</para>
                        /// </summary>
                        [NameInMap("ExpectValue")]
                        [Validation(Required=false)]
                        public string ExpectValue { get; set; }

                        /// <summary>
                        /// <para>The check operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ctn</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                    }

                    /// <summary>
                    /// <para>The exported parameters.</para>
                    /// </summary>
                    [NameInMap("ExportList")]
                    [Validation(Required=false)]
                    public List<GetPtsSceneResponseBodySceneRelationListApiListExportList> ExportList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListExportList : TeaModel {
                        /// <summary>
                        /// <para>The number of items or entries related to the export operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// <para>The path where the exported value can be found.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>data.username</para>
                        /// </summary>
                        [NameInMap("ExportName")]
                        [Validation(Required=false)]
                        public string ExportName { get; set; }

                        /// <summary>
                        /// <para>The format in which data is exported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BODY_JSON</para>
                        /// </summary>
                        [NameInMap("ExportType")]
                        [Validation(Required=false)]
                        public string ExportType { get; set; }

                        /// <summary>
                        /// <para>The parameter that is exported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>username</para>
                        /// </summary>
                        [NameInMap("ExportValue")]
                        [Validation(Required=false)]
                        public string ExportValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The headers used in the API request.</para>
                    /// </summary>
                    [NameInMap("HeaderList")]
                    [Validation(Required=false)]
                    public List<GetPtsSceneResponseBodySceneRelationListApiListHeaderList> HeaderList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListHeaderList : TeaModel {
                        /// <summary>
                        /// <para>The header name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userId</para>
                        /// </summary>
                        [NameInMap("HeaderName")]
                        [Validation(Required=false)]
                        public string HeaderName { get; set; }

                        /// <summary>
                        /// <para>The header value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1111</para>
                        /// </summary>
                        [NameInMap("HeaderValue")]
                        [Validation(Required=false)]
                        public string HeaderValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The request method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GET</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The number of redirections.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("RedirectCountLimit")]
                    [Validation(Required=false)]
                    public int? RedirectCountLimit { get; set; }

                    /// <summary>
                    /// <para>The timeout period. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TimeoutInSecond")]
                    [Validation(Required=false)]
                    public int? TimeoutInSecond { get; set; }

                    /// <summary>
                    /// <para>The URL to which the request is sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyundoc.com">https://www.aliyundoc.com</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The file parameters.</para>
                /// </summary>
                [NameInMap("FileParameterExplainList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class GetPtsSceneResponseBodySceneRelationListFileParameterExplainList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the file serves as the primary dataset for the test.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BaseFile")]
                    [Validation(Required=false)]
                    public bool? BaseFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameters are used for a single test execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CycleOnce")]
                    [Validation(Required=false)]
                    public bool? CycleOnce { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>city.csv</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The parameter names in the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userName,age</para>
                    /// </summary>
                    [NameInMap("FileParamName")]
                    [Validation(Required=false)]
                    public string FileParamName { get; set; }

                }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HNBGS7M</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// <para>The session name.</para>
                /// </summary>
                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGFJ7GV</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The name of the scenario</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The status of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
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
