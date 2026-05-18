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

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterOutputListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterOutputListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterOutputListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterOutputListResponseBodyDatapointsDatapoint : TeaModel {
                [NameInMap("ConfigJson")]
                [Validation(Required=false)]
                public DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson ConfigJson { get; set; }
                public class DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson : TeaModel {
                    [NameInMap("ak")]
                    [Validation(Required=false)]
                    public string Ak { get; set; }

                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DestName")]
                [Validation(Required=false)]
                public string DestName { get; set; }

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
