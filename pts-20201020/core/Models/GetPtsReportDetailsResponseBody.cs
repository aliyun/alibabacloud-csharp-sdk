// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsReportDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The metrics for API operations in the PTS scenario</para>
        /// </summary>
        [NameInMap("ApiMetricsList")]
        [Validation(Required=false)]
        public List<GetPtsReportDetailsResponseBodyApiMetricsList> ApiMetricsList { get; set; }
        public class GetPtsReportDetailsResponseBodyApiMetricsList : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11872</para>
            /// </summary>
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            /// <summary>
            /// <para>The name of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test-API</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The average response time. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170.49</para>
            /// </summary>
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public float? AvgRt { get; set; }

            /// <summary>
            /// <para>The average TPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.61</para>
            /// </summary>
            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public float? AvgTps { get; set; }

            /// <summary>
            /// <para>The number of business-related failures. If a checkpoint is defined, a failure occurs when the conditions for the checkpoint are not satisfied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCountBiz")]
            [Validation(Required=false)]
            public long? FailCountBiz { get; set; }

            /// <summary>
            /// <para>The number of failed requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            /// <summary>
            /// <para>The maximum response time. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public float? MaxRt { get; set; }

            /// <summary>
            /// <para>The minimum response time. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162</para>
            /// </summary>
            [NameInMap("MinRt")]
            [Validation(Required=false)]
            public float? MinRt { get; set; }

            /// <summary>
            /// <para>The 50th percentile response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168</para>
            /// </summary>
            [NameInMap("Seg50Rt")]
            [Validation(Required=false)]
            public float? Seg50Rt { get; set; }

            /// <summary>
            /// <para>The 75th percentile response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169</para>
            /// </summary>
            [NameInMap("Seg75Rt")]
            [Validation(Required=false)]
            public float? Seg75Rt { get; set; }

            /// <summary>
            /// <para>The 90th percentile response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170</para>
            /// </summary>
            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public float? Seg90Rt { get; set; }

            /// <summary>
            /// <para>The 99th percentile response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>284</para>
            /// </summary>
            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public float? Seg99Rt { get; set; }

            /// <summary>
            /// <para>The business success rate. The value is the ratio of the number of successful business to the total number of business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SuccessRateBiz")]
            [Validation(Required=false)]
            public float? SuccessRateBiz { get; set; }

            /// <summary>
            /// <para>The request success rate. The value is the ratio of the number of successful requests to the total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public float? SuccessRateReq { get; set; }

        }

        /// <summary>
        /// <para>The system status code. If the operation is successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If the operation is successful, this parameter is not returned.</para>
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
        /// <para>The summary of the report.</para>
        /// </summary>
        [NameInMap("ReportOverView")]
        [Validation(Required=false)]
        public GetPtsReportDetailsResponseBodyReportOverView ReportOverView { get; set; }
        public class GetPtsReportDetailsResponseBodyReportOverView : TeaModel {
            /// <summary>
            /// <para>The number of load generators. Each load generator has an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            /// <summary>
            /// <para>The end time of the performance testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-20 10:41:33</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GHB56VD</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The name of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PTS-TEST</para>
            /// </summary>
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            /// <summary>
            /// <para>The start time of the performance testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-20 10:39:33</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The virtual user minutes (VUM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1012</para>
            /// </summary>
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E3177-6745-4925-B423-4E89VV34221A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metrics of the scenario.</para>
        /// </summary>
        [NameInMap("SceneMetrics")]
        [Validation(Required=false)]
        public GetPtsReportDetailsResponseBodySceneMetrics SceneMetrics { get; set; }
        public class GetPtsReportDetailsResponseBodySceneMetrics : TeaModel {
            /// <summary>
            /// <para>The number of requests in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11872</para>
            /// </summary>
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            /// <summary>
            /// <para>The average response time in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170.49</para>
            /// </summary>
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public float? AvgRt { get; set; }

            /// <summary>
            /// <para>The average transactions per second (TPS) in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.61</para>
            /// </summary>
            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public float? AvgTps { get; set; }

            /// <summary>
            /// <para>The number of business failures in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCountBiz")]
            [Validation(Required=false)]
            public long? FailCountBiz { get; set; }

            /// <summary>
            /// <para>The number of failed requests in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            /// <summary>
            /// <para>The 90th percentile response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170</para>
            /// </summary>
            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public float? Seg90Rt { get; set; }

            /// <summary>
            /// <para>The 99th percentile response time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>284</para>
            /// </summary>
            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public float? Seg99Rt { get; set; }

            /// <summary>
            /// <para>The business success rate in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SuccessRateBiz")]
            [Validation(Required=false)]
            public float? SuccessRateBiz { get; set; }

            /// <summary>
            /// <para>The request success rate in the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public float? SuccessRateReq { get; set; }

        }

        /// <summary>
        /// <para>The snapshot of the scenario.</para>
        /// </summary>
        [NameInMap("SceneSnapShot")]
        [Validation(Required=false)]
        public GetPtsReportDetailsResponseBodySceneSnapShot SceneSnapShot { get; set; }
        public class GetPtsReportDetailsResponseBodySceneSnapShot : TeaModel {
            /// <summary>
            /// <para>The advanced settings of the scenario.</para>
            /// </summary>
            [NameInMap("AdvanceSetting")]
            [Validation(Required=false)]
            public GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSetting AdvanceSetting { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSetting : TeaModel {
                /// <summary>
                /// <para>The timeout period of the scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConnectionTimeoutInSecond")]
                [Validation(Required=false)]
                public int? ConnectionTimeoutInSecond { get; set; }

                /// <summary>
                /// <para>The domain name-IP address binding relationships.</para>
                /// </summary>
                [NameInMap("DomainBindingList")]
                [Validation(Required=false)]
                public List<GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSettingDomainBindingList> DomainBindingList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSettingDomainBindingList : TeaModel {
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
                    /// <para>The IP addresses bound to the domain name.</para>
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
                /// <para>429,404</para>
                /// </summary>
                [NameInMap("SuccessCode")]
                [Validation(Required=false)]
                public string SuccessCode { get; set; }

            }

            /// <summary>
            /// <para>The time when the scenario was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-20 09:28:10</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The file used in the scenario.</para>
            /// </summary>
            [NameInMap("FileParameterList")]
            [Validation(Required=false)]
            public List<GetPtsReportDetailsResponseBodySceneSnapShotFileParameterList> FileParameterList { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotFileParameterList : TeaModel {
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
                /// <para>The Object Storage Service (OSS) URL of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/test.csv">https://test-bucket.oss-cn-shanghai.aliyuncs.com/test.csv</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

            }

            /// <summary>
            /// <para>The global parameters.</para>
            /// </summary>
            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<GetPtsReportDetailsResponseBodySceneSnapShotGlobalParameterList> GlobalParameterList { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotGlobalParameterList : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user01</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// <para>The load settings.</para>
            /// </summary>
            [NameInMap("LoadConfig")]
            [Validation(Required=false)]
            public GetPtsReportDetailsResponseBodySceneSnapShotLoadConfig LoadConfig { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfig : TeaModel {
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
                public List<GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigApiLoadConfigList> ApiLoadConfigList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigApiLoadConfigList : TeaModel {
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
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

                /// <summary>
                /// <para>The concurrency and RPS limits in the scenario.</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigConfiguration Configuration { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The starting number of concurrent virtual users in the scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AllConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent virtual users in the scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("AllConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyLimit { get; set; }

                    /// <summary>
                    /// <para>The starting RPS in the scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AllRpsBegin")]
                    [Validation(Required=false)]
                    public int? AllRpsBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum RPS in the scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AllRpsLimit")]
                    [Validation(Required=false)]
                    public int? AllRpsLimit { get; set; }

                }

                /// <summary>
                /// <para>The maximum running time. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxRunningTime")]
                [Validation(Required=false)]
                public int? MaxRunningTime { get; set; }

                /// <summary>
                /// <para>The settings of the session.</para>
                /// </summary>
                [NameInMap("RelationLoadConfigList")]
                [Validation(Required=false)]
                public List<GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigRelationLoadConfigList> RelationLoadConfigList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigRelationLoadConfigList : TeaModel {
                    /// <summary>
                    /// <para>The starting number of concurrent virtual users.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? ConcurrencyBegin { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent virtual users.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("ConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? ConcurrencyLimit { get; set; }

                }

                /// <summary>
                /// <para>The load application mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TPS</para>
                /// </summary>
                [NameInMap("TestMode")]
                [Validation(Required=false)]
                public string TestMode { get; set; }

            }

            /// <summary>
            /// <para>The last modification time of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-10 10:10:10</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The sessions.</para>
            /// </summary>
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationList> RelationList { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotRelationList : TeaModel {
                /// <summary>
                /// <para>The settings of the API operation.</para>
                /// </summary>
                [NameInMap("ApiList")]
                [Validation(Required=false)]
                public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiList> ApiList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the API operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MNB45</para>
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The name of the API operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test-API</para>
                    /// </summary>
                    [NameInMap("ApiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <para>The request body.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListBody Body { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListBody : TeaModel {
                        /// <summary>
                        /// <para>The content of the request body.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{key:value}</para>
                        /// </summary>
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        /// <summary>
                        /// <para>The type of the request body.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>application/x-www-form-urlencoded</para>
                        /// </summary>
                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    /// <summary>
                    /// <para>The checkpoints of the API operation.</para>
                    /// </summary>
                    [NameInMap("CheckPointList")]
                    [Validation(Required=false)]
                    public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListCheckPointList : TeaModel {
                        /// <summary>
                        /// <para>The checked item.</para>
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
                    /// <para>The export parameters.</para>
                    /// </summary>
                    [NameInMap("ExportList")]
                    [Validation(Required=false)]
                    public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListExportList> ExportList { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListExportList : TeaModel {
                        /// <summary>
                        /// <para>The index of the export parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// <para>The name of the export parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userId</para>
                        /// </summary>
                        [NameInMap("ExportName")]
                        [Validation(Required=false)]
                        public string ExportName { get; set; }

                        /// <summary>
                        /// <para>The source of the export parameter.</para>
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
                        /// <para>data.userId</para>
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
                    public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListHeaderList> HeaderList { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListHeaderList : TeaModel {
                        /// <summary>
                        /// <para>The name of the header.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>User-Agent</para>
                        /// </summary>
                        [NameInMap("HeaderName")]
                        [Validation(Required=false)]
                        public string HeaderName { get; set; }

                        /// <summary>
                        /// <para>The value of the header.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PTS</para>
                        /// </summary>
                        [NameInMap("HeaderValue")]
                        [Validation(Required=false)]
                        public string HeaderValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The method of the request.</para>
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
                    /// <para>The timeout period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TimeoutInSecond")]
                    [Validation(Required=false)]
                    public int? TimeoutInSecond { get; set; }

                    /// <summary>
                    /// <para>The URL to which the API request is sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/">http://www.example.com/</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The file parameters used by the session.</para>
                /// </summary>
                [NameInMap("FileParameterExplainList")]
                [Validation(Required=false)]
                public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListFileParameterExplainList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the file is used as the baseline file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BaseFile")]
                    [Validation(Required=false)]
                    public bool? BaseFile { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameters are used once.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CycleOnce")]
                    [Validation(Required=false)]
                    public bool? CycleOnce { get; set; }

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
                    /// <para>The parameters in the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>username</para>
                    /// </summary>
                    [NameInMap("FileParamName")]
                    [Validation(Required=false)]
                    public string FileParamName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGBN4D</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// <para>The name of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-session-1</para>
                /// </summary>
                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7HBNS3</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The name of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PTS-TEST</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The status of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STOPPED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
