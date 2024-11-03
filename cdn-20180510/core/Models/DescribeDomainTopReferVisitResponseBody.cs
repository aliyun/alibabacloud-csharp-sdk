// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTopReferVisitResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95994621-8382-464B-8762-C708E73568D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-21T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The most frequently requested web pages.</para>
        /// </summary>
        [NameInMap("TopReferList")]
        [Validation(Required=false)]
        public DescribeDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The URLs to the most frequently requested web pages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>learn.aliyundoc.com</para>
                /// </summary>
                [NameInMap("ReferDetail")]
                [Validation(Required=false)]
                public string ReferDetail { get; set; }

                /// <summary>
                /// <para>The number of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

    }

}
