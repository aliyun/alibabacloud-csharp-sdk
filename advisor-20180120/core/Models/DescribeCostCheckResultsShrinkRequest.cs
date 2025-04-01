// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeCostCheckResultsShrinkRequest : TeaModel {
        [NameInMap("AssumeAliyunIdList")]
        [Validation(Required=false)]
        public string AssumeAliyunIdListShrink { get; set; }

        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Category</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        [NameInMap("ResourceGroupIdList")]
        [Validation(Required=false)]
        public string ResourceGroupIdListShrink { get; set; }

        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYNC_********_TASK</para>
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
        public int? Severity { get; set; }

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
