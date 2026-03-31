// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplateValidResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C54DD36B-6380-57E5-89BA-2642757C4DB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
