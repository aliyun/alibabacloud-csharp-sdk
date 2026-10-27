// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The fuzzy match value used to query images.</para>
        /// <remarks>
        /// <para>This parameter supports fuzzy queries for image IDs, image tags, image instance IDs, image repository names, image repository IDs, image repository namespaces, image regions, image digests, and image repository types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>525</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
