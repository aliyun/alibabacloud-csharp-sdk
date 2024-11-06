// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopReferVisitResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95994621-8382-464B-8762-C708E73568D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of frequently referenced URLs returned.</para>
        /// </summary>
        [NameInMap("TopReferList")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopReferVisitResponseBodyTopReferList TopReferList { get; set; }
        public class DescribeDcdnDomainTopReferVisitResponseBodyTopReferList : TeaModel {
            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopReferVisitResponseBodyTopReferListReferList> ReferList { get; set; }
            public class DescribeDcdnDomainTopReferVisitResponseBodyTopReferListReferList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. (Unit: bytes)</para>
                /// 
                /// <b>Example:</b>
                /// <para>460486880</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The complete referenced URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1</para>
                /// </summary>
                [NameInMap("ReferDetail")]
                [Validation(Required=false)]
                public string ReferDetail { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>229567</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

    }

}
