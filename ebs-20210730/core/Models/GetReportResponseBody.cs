// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class GetReportResponseBody : TeaModel {
        /// <summary>
        /// <para>Data Details.</para>
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<GetReportResponseBodyDatas> Datas { get; set; }
        public class GetReportResponseBodyDatas : TeaModel {
            /// <summary>
            /// <para>Data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetReportResponseBodyDatasData> Data { get; set; }
            public class GetReportResponseBodyDatasData : TeaModel {
                /// <summary>
                /// <para>Data Points.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;1726416000&quot;: 0.44,
                ///   &quot;1726502400&quot;: 0.44,
                ///   &quot;1726588800&quot;: 0.44,
                ///   &quot;1726675200&quot;: 0.44,
                ///   &quot;1726761600&quot;: 0.43,
                ///   &quot;1726848000&quot;: 0.43,
                ///   &quot;1726934400&quot;: 0.43,
                ///   &quot;1727020800&quot;: 0.43
                /// }</para>
                /// </summary>
                [NameInMap("DataPoints")]
                [Validation(Required=false)]
                public Dictionary<string, object> DataPoints { get; set; }

                /// <summary>
                /// <para>Data Labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;category&quot;: &quot;cloud&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, object> Labels { get; set; }

            }

            /// <summary>
            /// <para>Data Title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk_count_percent_by_category</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C123F94F-4E38-19AE-942A-A8D6F44F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
