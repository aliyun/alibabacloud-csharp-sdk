// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListApiDatasourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListApiDatasourceResponseBodyResult Result { get; set; }
        public class ListApiDatasourceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of API data sources.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListApiDatasourceResponseBodyResultData> Data { get; set; }
            public class ListApiDatasourceResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The ID of the API data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0f2c3c6409be4dc0810f2a5785e816a8</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The query statement parameter settings in JSON format, which can be user-defined.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>The data volume of the API data source.</para>
                /// <list type="bullet">
                /// <item><description>Unit: KB.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0.39746094</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public float? DataSize { get; set; }

                /// <summary>
                /// <para>The last synchronization time of the API data source. Format example: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-25 16:19:43</para>
                /// </summary>
                [NameInMap("DateUpdateTime")]
                [Validation(Required=false)]
                public string DateUpdateTime { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-25 16:19:43</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-25 16:19:43</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REST_API_SYNC_0f2c3c6409be4dc0810f2a5785e816a8</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The parameter settings in JSONArray format.</para>
                /// <list type="bullet">
                /// <item><description>name: the parameter name.</description></item>
                /// <item><description>value: the parameter value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;:&quot;token&quot;,&quot;value&quot;:&quot;xxxxxxxxxxxx&quot;},{&quot;name&quot;:&quot;pageSize&quot;,&quot;value&quot;:100}]</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The name of the API data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestDataSource</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The synchronization task status of the API data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StatusType")]
                [Validation(Required=false)]
                public int? StatusType { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned data, used for pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of rows per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
