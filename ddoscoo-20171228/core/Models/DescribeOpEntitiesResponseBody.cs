// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        [NameInMap("OpEntities")]
        [Validation(Required=false)]
        public List<DescribeOpEntitiesResponseBodyOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseBodyOpEntities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2.2.2.2</para>
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1536715558000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;newEntity&quot;:{&quot;elasticBandwidth&quot;:30},&quot;oldEntity&quot;:{&quot;elasticBandwidth&quot;:200}}</para>
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
