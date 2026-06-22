// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The search value for image repositories.</para>
        /// <remarks>
        /// <para>This parameter supports fuzzy match for image IDs, tags, image instance IDs, repository names, repository namespaces, repository IDs, repository regions, digests, and repository types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.2</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
