// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeTemplateResourceCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8064433-9781-5E86-806E-C1DD****1D95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of protected objects or protected object groups for which the protection template takes effect.</para>
        /// </summary>
        [NameInMap("ResourceCount")]
        [Validation(Required=false)]
        public List<DescribeTemplateResourceCountResponseBodyResourceCount> ResourceCount { get; set; }
        public class DescribeTemplateResourceCountResponseBodyResourceCount : TeaModel {
            /// <summary>
            /// <para>The number of protected object groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// <para>The number of protected objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SingleCount")]
            [Validation(Required=false)]
            public int? SingleCount { get; set; }

            /// <summary>
            /// <para>The ID of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
