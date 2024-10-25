// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeRegionIspsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ISPs.</para>
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribeRegionIspsResponseBodyIsps> Isps { get; set; }
        public class DescribeRegionIspsResponseBodyIsps : TeaModel {
            /// <summary>
            /// <para>The code of the ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The name of the ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>move</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC90CC7E-23B6-5A90-9097-A17CE4A161C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
