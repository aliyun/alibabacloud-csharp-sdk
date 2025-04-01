// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeCostCheckAdvicesShrinkRequest : TeaModel {
        [NameInMap("AssumeAliyunIdList")]
        [Validation(Required=false)]
        public string AssumeAliyunIdListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EcsCostLowUtilizationCheck</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeysShrink { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public string TagListShrink { get; set; }

        [NameInMap("TagValues")]
        [Validation(Required=false)]
        public string TagValuesShrink { get; set; }

    }

}
