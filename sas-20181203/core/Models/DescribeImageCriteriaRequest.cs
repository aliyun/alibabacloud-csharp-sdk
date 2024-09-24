// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The keyword that you specify for fuzzy search when you query the image.</para>
        /// <remarks>
        /// <para>The value of this parameter can be an image ID, image tag, image instance ID, image repository name, image repository ID, image repository namespace, image region, image digest, or image repository type.</para>
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
