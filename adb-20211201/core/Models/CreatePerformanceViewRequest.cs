// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreatePerformanceViewRequest : TeaModel {
        [NameInMap("CreateFromViewType")]
        [Validation(Required=false)]
        public string CreateFromViewType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("FillOriginViewKeys")]
        [Validation(Required=false)]
        public bool? FillOriginViewKeys { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public CreatePerformanceViewRequestViewDetail ViewDetail { get; set; }
        public class CreatePerformanceViewRequestViewDetail : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<CreatePerformanceViewRequestViewDetailCategories> Categories { get; set; }
            public class CreatePerformanceViewRequestViewDetailCategories : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<CreatePerformanceViewRequestViewDetailCategoriesKeys> Keys { get; set; }
                public class CreatePerformanceViewRequestViewDetailCategoriesKeys : TeaModel {
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            [NameInMap("ChartLinked")]
            [Validation(Required=false)]
            public bool? ChartLinked { get; set; }

            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}
