// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoCriteriaRequest : TeaModel {
        /// <summary>
        /// The value of the filter condition.
        /// 
        /// > You can perform fuzzy search based on the image ID, image tag, image instance ID, image repository name, image repository namespace, image repository ID, image repository region, image digest, and image repository type.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
