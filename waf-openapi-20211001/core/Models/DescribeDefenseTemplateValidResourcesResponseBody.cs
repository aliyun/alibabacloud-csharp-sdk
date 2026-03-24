// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplateValidResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C54DD36B-6380-57E5-89BA-2642757C4DB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The names of the protected objects that are valid for the protection template.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// <para>The total number of protected objects that match the query criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
