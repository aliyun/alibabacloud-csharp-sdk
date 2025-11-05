// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSubListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the custom report task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;3250A51D-C11D-46BA-B6B3-95348EEDE652&quot;,&quot;Description&quot;:&quot;Successful&quot;,&quot;Content&quot;:{&quot;data&quot;:[{&quot;subId&quot;:5,&quot;reportId&quot;:[1,2,3],&quot;createTime&quot;:&quot;2020-09-25T09:39:33Z&quot;,&quot;domains&quot;[&quot;<a href="http://www.example.com%22,%22www.example.com%22%5D,%22effectiveFrom%22:%222020-09-17T00:00:00Z%22,%22effectiveEnd%22:%222020-11-17T00:00:00Z%22,%22status%22:%22enable%22%7D%5D%7D%7D">www.example.com&quot;,&quot;www.example.com&quot;],&quot;effectiveFrom&quot;:&quot;2020-09-17T00:00:00Z&quot;,&quot;effectiveEnd&quot;:&quot;2020-11-17T00:00:00Z&quot;,&quot;status&quot;:&quot;enable&quot;}]}}</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCdnSubListResponseBodyContent Content { get; set; }
        public class DescribeCdnSubListResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeCdnSubListResponseBodyContentData> Data { get; set; }
            public class DescribeCdnSubListResponseBodyContentData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-16T09:43:38Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-16T09:43:38Z</para>
                /// </summary>
                [NameInMap("effectiveEnd")]
                [Validation(Required=false)]
                public string EffectiveEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-16T09:43:38Z</para>
                /// </summary>
                [NameInMap("effectiveFrom")]
                [Validation(Required=false)]
                public string EffectiveFrom { get; set; }

                [NameInMap("reportId")]
                [Validation(Required=false)]
                public List<long?> ReportId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("subId")]
                [Validation(Required=false)]
                public long? SubId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3250A51D-C11D-46BA-B6B3-95348EEDE652</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
