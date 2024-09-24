// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterOutputListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The configuration sets for exporting monitoring data.</para>
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterOutputListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterOutputListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterOutputListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterOutputListResponseBodyDatapointsDatapoint : TeaModel {
                /// <summary>
                /// <para>The JSON object that contains the details about the destination to which the monitoring data is exported.</para>
                /// </summary>
                [NameInMap("ConfigJson")]
                [Validation(Required=false)]
                public DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson ConfigJson { get; set; }
                public class DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson : TeaModel {
                    /// <summary>
                    /// <para>The AccessKey ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LTAIpY33********</para>
                    /// </summary>
                    [NameInMap("ak")]
                    [Validation(Required=false)]
                    public string Ak { get; set; }

                    /// <summary>
                    /// <para>The Log Service endpoint to which the monitoring data is exported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://cn-qingdao-share.log.aliyuncs.com">http://cn-qingdao-share.log.aliyuncs.com</a></para>
                    /// </summary>
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>The Logstore.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>monitorlogstore</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The Log Service project to which the monitoring data is exported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>exporter</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

                /// <summary>
                /// <para>The time when the configuration set was created. The value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1584016495498</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the configuration set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exporterOut</para>
                /// </summary>
                [NameInMap("DestName")]
                [Validation(Required=false)]
                public string DestName { get; set; }

                /// <summary>
                /// <para>The service to which the monitoring data is exported.</para>
                /// <remarks>
                /// <para>Only Log Service is supported. More services will be supported in the future.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SLS</para>
                /// </summary>
                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sucess</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E657631-CD6C-4C24-9637-98D000B9272C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
