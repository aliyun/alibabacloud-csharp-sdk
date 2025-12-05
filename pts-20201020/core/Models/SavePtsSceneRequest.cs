// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SavePtsSceneRequest : TeaModel {
        /// <summary>
        /// <para>The information about the scenario.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public SavePtsSceneRequestScene Scene { get; set; }
        public class SavePtsSceneRequestScene : TeaModel {
            /// <summary>
            /// <para>The advanced settings.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("AdvanceSetting")]
            [Validation(Required=false)]
            public SavePtsSceneRequestSceneAdvanceSetting AdvanceSetting { get; set; }
            public class SavePtsSceneRequestSceneAdvanceSetting : TeaModel {
                /// <summary>
                /// <para>The timeout period. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConnectionTimeoutInSecond")]
                [Validation(Required=false)]
                public int? ConnectionTimeoutInSecond { get; set; }

                /// <summary>
                /// <para>The domain name-IP address binding relationships</para>
                /// </summary>
                [NameInMap("DomainBindingList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneAdvanceSettingDomainBindingList> DomainBindingList { get; set; }
                public class SavePtsSceneRequestSceneAdvanceSettingDomainBindingList : TeaModel {
                    /// <summary>
                    /// <para>The domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>The IP addresses.</para>
                    /// </summary>
                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                /// <summary>
                /// <para>The log sampling rate. Valid values: 1, 10, 20, 30, 40, and 50.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LogRate")]
                [Validation(Required=false)]
                public int? LogRate { get; set; }

                /// <summary>
                /// <para>The success status code. Separate multiple status codes with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>205</para>
                /// </summary>
                [NameInMap("SuccessCode")]
                [Validation(Required=false)]
                public string SuccessCode { get; set; }

            }

            /// <summary>
            /// <para>The file parameters.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("FileParameterList")]
            [Validation(Required=false)]
            public List<SavePtsSceneRequestSceneFileParameterList> FileParameterList { get; set; }
            public class SavePtsSceneRequestSceneFileParameterList : TeaModel {
                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.csv</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The OSS URL of the file, which must be accessible over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://jmeter-pts-testing-version.oss-cn-shanghai.aliyuncs.com/param-file.csv">https://jmeter-pts-testing-version.oss-cn-shanghai.aliyuncs.com/param-file.csv</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

            }

            /// <summary>
            /// <para>The global customization parameters.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<SavePtsSceneRequestSceneGlobalParameterList> GlobalParameterList { get; set; }
            public class SavePtsSceneRequestSceneGlobalParameterList : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11111</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// <para>The load settings.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LoadConfig")]
            [Validation(Required=false)]
            public SavePtsSceneRequestSceneLoadConfig LoadConfig { get; set; }
            public class SavePtsSceneRequestSceneLoadConfig : TeaModel {
                /// <summary>
                /// <para>The number of load generators. If the number of concurrent virtual users exceeds 250 or the RPS exceeds 2,000, you can use multiple load generators. The maximum number of load generators is limited to the total number of concurrent virtual users divided by 250 or the total RPS divided by 200.</para>
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
                public List<SavePtsSceneRequestSceneLoadConfigApiLoadConfigList> ApiLoadConfigList { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigApiLoadConfigList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the API.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The starting RPS.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("RpsBegin")]
                    [Validation(Required=false)]
                    public int? RpsBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum RPS.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the load is automatically incremented. This parameter takes effect only if you set <c>TestMode=concurrency_mode</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoStep")]
                [Validation(Required=false)]
                public bool? AutoStep { get; set; }

                /// <summary>
                /// <para>The load level settings of the scenario.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public SavePtsSceneRequestSceneLoadConfigConfiguration Configuration { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The starting total number of concurrent virtual users in all sessions.</para>
                    /// <para>The value is evenly distributed among all sessions if you set TestMode to concurrency_mode. If you do not specify this parameter, you must configure <b>relationLoadConfig</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum total number of concurrent virtual users in all sessions.</para>
                    /// <para>The value is evenly distributed among all sessions if you set TestMode to concurrency_mode. If you do not specify this parameter, you must configure <b>relationLoadConfig</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyLimit { get; set; }

                    /// <summary>
                    /// <para>The starting RPS for all APIs.</para>
                    /// <para>The value is evenly distributed among all APIs if you set TestMode to RPS. If you do not specify this parameter, you must specify <b>apiLoadConfig</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllRpsBegin")]
                    [Validation(Required=false)]
                    public int? AllRpsBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum RPS for all APIs.</para>
                    /// <para>The value is evenly distributed among all APIs if you set TestMode to RPS. If you do not specify this parameter, you must specify <b>apiLoadConfig</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllRpsLimit")]
                    [Validation(Required=false)]
                    public int? AllRpsLimit { get; set; }

                }

                /// <summary>
                /// <para>The increment percentage. Valid values: 10 to 100, in increments of 10.</para>
                /// <para>This parameter takes effect only if you set <c>testMode=concurrency_mode</c>and <c>autoStep=true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Increment")]
                [Validation(Required=false)]
                public int? Increment { get; set; }

                /// <summary>
                /// <para>The duration of a specific load level. Unit: minutes. The value must be less than the value of <b>maxRunningTime</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("KeepTime")]
                [Validation(Required=false)]
                public int? KeepTime { get; set; }

                /// <summary>
                /// <para>The duration of load application. Unit: minutes. Valid values: 1 to 1440.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxRunningTime")]
                [Validation(Required=false)]
                public int? MaxRunningTime { get; set; }

                /// <summary>
                /// <para>The session settings.</para>
                /// </summary>
                [NameInMap("RelationLoadConfigList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneLoadConfigRelationLoadConfigList> RelationLoadConfigList { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigRelationLoadConfigList : TeaModel {
                    /// <summary>
                    /// <para>The starting number of concurrent virtual users.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? ConcurrencyBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent virtual users.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? ConcurrencyLimit { get; set; }

                    /// <summary>
                    /// <para>The ID of the session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RelationId")]
                    [Validation(Required=false)]
                    public string RelationId { get; set; }

                }

                /// <summary>
                /// <para>The load application mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>concurrency_mode: concurrency mode</description></item>
                /// <item><description>tps_mode: RPS mode.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>concurrency_mode</para>
                /// </summary>
                [NameInMap("TestMode")]
                [Validation(Required=false)]
                public string TestMode { get; set; }

                /// <summary>
                /// <para>The VPC settings.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("VpcLoadConfig")]
                [Validation(Required=false)]
                public SavePtsSceneRequestSceneLoadConfigVpcLoadConfig VpcLoadConfig { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigVpcLoadConfig : TeaModel {
                    /// <summary>
                    /// <para>The ID of the region.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-jkasgfieiajidsjakjscb</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-skjfhlahsljkhsfalkjdoiw</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC.</para>
                    /// <para>This parameter is required.</para>
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
            /// <para>The sessions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<SavePtsSceneRequestSceneRelationList> RelationList { get; set; }
            public class SavePtsSceneRequestSceneRelationList : TeaModel {
                /// <summary>
                /// <para>The API operations on the session.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ApiList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneRelationListApiList> ApiList { get; set; }
                public class SavePtsSceneRequestSceneRelationListApiList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The name of the API operation.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api</para>
                    /// </summary>
                    [NameInMap("ApiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <para>The request body.</para>
                    /// 
                    /// <b>if can be null:</b>
                    /// <c>true</c>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public SavePtsSceneRequestSceneRelationListApiListBody Body { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListBody : TeaModel {
                        /// <summary>
                        /// <para>The data in the body. For example, {&quot;key1&quot;:&quot;value2&quot;,&quot;key2&quot;:&quot;value2&quot;}.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{\&quot;global\&quot;:\&quot;${global}\&quot;,\&quot;name\&quot;:\&quot;${name}\&quot;}</para>
                        /// </summary>
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        /// <summary>
                        /// <para>The body type. Default: <c>application/x-www-form-urlencoded</c>.</para>
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
                    public List<SavePtsSceneRequestSceneRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListCheckPointList : TeaModel {
                        /// <summary>
                        /// <para>The checked item.</para>
                        /// <para>This parameter specifies the fields in the header if you specify <c>CheckType=HEADER</c> or the name of the export parameter if you specify <c>CheckType=EXPORTED_PARAM</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userId</para>
                        /// </summary>
                        [NameInMap("CheckPoint")]
                        [Validation(Required=false)]
                        public string CheckPoint { get; set; }

                        /// <summary>
                        /// <para>The type of check. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>BODY_TEXT: the response body</description></item>
                        /// <item><description>HEADER: the response headers</description></item>
                        /// <item><description>STATUS_CODE: the HTTP status code returned by the API</description></item>
                        /// <item><description>EXPORTED_PARAM: a specific export parameter</description></item>
                        /// </list>
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
                        /// <para>The operation or condition that is checked against the expected value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ctn</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                    }

                    /// <summary>
                    /// <para>The export parameters.</para>
                    /// </summary>
                    [NameInMap("ExportList")]
                    [Validation(Required=false)]
                    public List<SavePtsSceneRequestSceneRelationListApiListExportList> ExportList { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListExportList : TeaModel {
                        /// <summary>
                        /// <para>The index of the matched item. You can specify a number or &quot;Random&quot;. If you set ExportType to BODY_TEXT, you must specify this parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// <para>The name of the export parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("ExportName")]
                        [Validation(Required=false)]
                        public string ExportName { get; set; }

                        /// <summary>
                        /// <para>The source of the export parameter. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>BODY_TEXT: the request body in the BODY_TEXT format</description></item>
                        /// <item><description>BODY_JSON: the request body in the BODY_JSON format.</description></item>
                        /// <item><description>HEADER: the request header</description></item>
                        /// <item><description>STATUS_CODE: the HTTP status code returned by the API</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BODY_JSON</para>
                        /// </summary>
                        [NameInMap("ExportType")]
                        [Validation(Required=false)]
                        public string ExportType { get; set; }

                        /// <summary>
                        /// <para>The actual path from which you want to extract the export parameter values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>data.itemlist[0]</para>
                        /// </summary>
                        [NameInMap("ExportValue")]
                        [Validation(Required=false)]
                        public string ExportValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The headers.</para>
                    /// </summary>
                    [NameInMap("HeaderList")]
                    [Validation(Required=false)]
                    public List<SavePtsSceneRequestSceneRelationListApiListHeaderList> HeaderList { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListHeaderList : TeaModel {
                        /// <summary>
                        /// <para>The name of the header.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Accept-Encoding</para>
                        /// </summary>
                        [NameInMap("HeaderName")]
                        [Validation(Required=false)]
                        public string HeaderName { get; set; }

                        /// <summary>
                        /// <para>The value of the header.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>gzip, deflate, br</para>
                        /// </summary>
                        [NameInMap("HeaderValue")]
                        [Validation(Required=false)]
                        public string HeaderValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The request method.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GET</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The number of redirections. The value can be 0, which specifies that redirection is allowed, or 10, which specifies that redirection is not allowed. You can specify a value based on your business requirements.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RedirectCountLimit")]
                    [Validation(Required=false)]
                    public int? RedirectCountLimit { get; set; }

                    /// <summary>
                    /// <para>The timeout period of the API operation. Unit: seconds. Default: 5. Valid values: 1 to 60.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TimeoutInSecond")]
                    [Validation(Required=false)]
                    public int? TimeoutInSecond { get; set; }

                    /// <summary>
                    /// <para>The URL to which the API request is sent.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The file parameters of the session.</para>
                /// </summary>
                [NameInMap("FileParameterExplainList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class SavePtsSceneRequestSceneRelationListFileParameterExplainList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether the file is used as the baseline file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BaseFile")]
                    [Validation(Required=false)]
                    public bool? BaseFile { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the file is used for a single execution of the test.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CycleOnce")]
                    [Validation(Required=false)]
                    public bool? CycleOnce { get; set; }

                    /// <summary>
                    /// <para>The name of the file.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fileName.csv</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The parameter names in the file.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name,uid,age</para>
                    /// </summary>
                    [NameInMap("FileParamName")]
                    [Validation(Required=false)]
                    public string FileParamName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// <para>The name of the session.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the scenario. To save a new scenario, leave this parameter empty. To update an existing scenario, specify the ID of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IUYAHGJ</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The name of the scenario.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

        }

    }

}
