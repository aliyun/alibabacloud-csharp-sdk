// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the operations report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;:[{&quot;deliver&quot;:{&quot;report&quot;:{&quot;title&quot;:&quot;TopUrlByAcc&quot;,&quot;format&quot;:&quot;table&quot;,&quot;shape&quot;:&quot;&quot;,&quot;header&quot;:[&quot;url&quot;,&quot;traf&quot;,&quot;traf_rate&quot;,&quot;acc&quot;,&quot;acc_rate&quot;]}},&quot;data&quot;:[{&quot;acc&quot;:440,&quot;acc_rate&quot;:&quot;0.200%&quot;,&quot;traf&quot;:22,&quot;url&quot;:&quot;<a href="http://demo.com%22,%22traf_rate%22:%220.100%%22%7D,%7B%22acc%22:440,%22acc_rate%22:%220.200%%22,%22traf%22:22,%22url%22:%22http://demo.com%22,%22traf_rate%22:%220.100%%22%7D%5D%7D%5D%7D%7D">http://demo.com&quot;,&quot;traf_rate&quot;:&quot;0.100%&quot;},{&quot;acc&quot;:440,&quot;acc_rate&quot;:&quot;0.200%&quot;,&quot;traf&quot;:22,&quot;url&quot;:&quot;http://demo.com&quot;,&quot;traf_rate&quot;:&quot;0.100%&quot;}]}]}}</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCdnReportResponseBodyContent Content { get; set; }
        public class DescribeCdnReportResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeCdnReportResponseBodyContentData> Data { get; set; }
            public class DescribeCdnReportResponseBodyContentData : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Data { get; set; }

                [NameInMap("deliver")]
                [Validation(Required=false)]
                public DescribeCdnReportResponseBodyContentDataDeliver Deliver { get; set; }
                public class DescribeCdnReportResponseBodyContentDataDeliver : TeaModel {
                    [NameInMap("report")]
                    [Validation(Required=false)]
                    public DescribeCdnReportResponseBodyContentDataDeliverReport Report { get; set; }
                    public class DescribeCdnReportResponseBodyContentDataDeliverReport : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table</para>
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("header")]
                        [Validation(Required=false)]
                        public List<string> Header { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("outLine")]
                        [Validation(Required=false)]
                        public long? OutLine { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("outSize")]
                        [Validation(Required=false)]
                        public long? OutSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>line</para>
                        /// </summary>
                        [NameInMap("shape")]
                        [Validation(Required=false)]
                        public string Shape { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
