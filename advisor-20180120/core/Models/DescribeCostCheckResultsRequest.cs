// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeCostCheckResultsRequest : TeaModel {
        [NameInMap("AssumeAliyunIdList")]
        [Validation(Required=false)]
        public List<long?> AssumeAliyunIdList { get; set; }

        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<string> CheckIds { get; set; }

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
        public List<string> RegionIds { get; set; }

        [NameInMap("ResourceGroupIdList")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIdList { get; set; }

        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

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
        public List<string> TagKeys { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<DescribeCostCheckResultsRequestTagList> TagList { get; set; }
        public class DescribeCostCheckResultsRequestTagList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ERP</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public List<string> TagValue { get; set; }

        }

        [NameInMap("TagValues")]
        [Validation(Required=false)]
        public List<string> TagValues { get; set; }

    }

}
