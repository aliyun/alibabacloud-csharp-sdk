// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDeliverListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;: [{&quot;deliverId&quot;: 1,&quot;status&quot;: &quot;enable&quot;,&quot;createTime&quot;: &quot;2020-10-14T11:19:26Z&quot;,&quot;crontab&quot;: &quot;0 0 0 \* \* ?&quot;,&quot;frequency&quot;: &quot;d&quot;,&quot;name&quot;: &quot;The name of the tracking task&quot;,&quot;dmList&quot;: [&quot;<a href="http://www.example.com%22%5D,%22reports">www.example.com&quot;],&quot;reports</a>&quot;: [{&quot;reportId&quot;: 1,&quot;conditions&quot;: [{&quot;op&quot;: &quot;in&quot;,&quot;field&quot;: &quot;prov&quot;,&quot;value&quot;: [&quot;Heilongjiang&quot;,&quot;Beijing&quot;]}} },{&quot;reportId&quot;: 2}],&quot;deliver&quot;: {&quot;email&quot;: {&quot;subject&quot;: &quot;subject&quot;,&quot;to&quot;: [&quot;<a href="mailto:example@alibaba-inc.com">example@alibaba-inc.com</a>&quot;,&quot;<a href="mailto:example@alibaba-inc.com">example@alibaba-inc.com</a>&quot;]}}}]}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCdnDeliverListResponseBodyContent Content { get; set; }
        public class DescribeCdnDeliverListResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeCdnDeliverListResponseBodyContentData> Data { get; set; }
            public class DescribeCdnDeliverListResponseBodyContentData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-12-30T10:29:29Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00 00 08 * * ?</para>
                /// </summary>
                [NameInMap("crontab")]
                [Validation(Required=false)]
                public string Crontab { get; set; }

                [NameInMap("deliver")]
                [Validation(Required=false)]
                public DescribeCdnDeliverListResponseBodyContentDataDeliver Deliver { get; set; }
                public class DescribeCdnDeliverListResponseBodyContentDataDeliver : TeaModel {
                    [NameInMap("email")]
                    [Validation(Required=false)]
                    public DescribeCdnDeliverListResponseBodyContentDataDeliverEmail Email { get; set; }
                    public class DescribeCdnDeliverListResponseBodyContentDataDeliverEmail : TeaModel {
                        [NameInMap("to")]
                        [Validation(Required=false)]
                        public List<string> To { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("deliverId")]
                [Validation(Required=false)]
                public long? DeliverId { get; set; }

                [NameInMap("dmList")]
                [Validation(Required=false)]
                public List<string> DmList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d</para>
                /// </summary>
                [NameInMap("frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("reports")]
                [Validation(Required=false)]
                public List<DescribeCdnDeliverListResponseBodyContentDataReports> Reports { get; set; }
                public class DescribeCdnDeliverListResponseBodyContentDataReports : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("reportId")]
                    [Validation(Required=false)]
                    public long? ReportId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1d</para>
                /// </summary>
                [NameInMap("timeEndFormat")]
                [Validation(Required=false)]
                public string TimeEndFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1d</para>
                /// </summary>
                [NameInMap("timeFromFormat")]
                [Validation(Required=false)]
                public string TimeFromFormat { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
