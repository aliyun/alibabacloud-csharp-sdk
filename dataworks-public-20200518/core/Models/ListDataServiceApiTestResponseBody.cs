// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceApiTestResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataServiceApiTestResponseBodyData> Data { get; set; }
        public class ListDataServiceApiTestResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the API to test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2343</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>The time consumed by the API request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public int? CostTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// <para>The value is a 13-digit number, such as <c>1651824913000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651824913000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The request parameters of the test API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;test&quot;}</para>
            /// </summary>
            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public string ParamMap { get; set; }

            /// <summary>
            /// <para>The return code of the test API. This field is empty if the test is not completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public long? RetCode { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:2}</para>
            /// </summary>
            [NameInMap("RetResult")]
            [Validation(Required=false)]
            public string RetResult { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is completed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING</description></item>
            /// <item><description>FINISHED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The test ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TestId")]
            [Validation(Required=false)]
            public long? TestId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ESDAFWEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
