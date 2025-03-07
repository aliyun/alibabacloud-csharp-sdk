// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The types of the domain names.</para>
        /// </summary>
        [NameInMap("CdnTypes")]
        [Validation(Required=false)]
        public DescribeCdnTypesResponseBodyCdnTypes CdnTypes { get; set; }
        public class DescribeCdnTypesResponseBodyCdnTypes : TeaModel {
            [NameInMap("CdnType")]
            [Validation(Required=false)]
            public List<DescribeCdnTypesResponseBodyCdnTypesCdnType> CdnType { get; set; }
            public class DescribeCdnTypesResponseBodyCdnTypesCdnType : TeaModel {
                /// <summary>
                /// <para>The description of the domain name type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Download Acceleration</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The type of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>download</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDA62CE4-3477-439A-B52E-D2D7C829D7C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
