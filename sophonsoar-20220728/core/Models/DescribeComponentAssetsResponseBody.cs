// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentAssetsResponseBody : TeaModel {
        /// <summary>
        /// The information about the assets.
        /// </summary>
        [NameInMap("ComponentAssets")]
        [Validation(Required=false)]
        public List<DescribeComponentAssetsResponseBodyComponentAssets> ComponentAssets { get; set; }
        public class DescribeComponentAssetsResponseBodyComponentAssets : TeaModel {
            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("AssetUuid")]
            [Validation(Required=false)]
            public string AssetUuid { get; set; }

            /// <summary>
            /// The name of the component to which the asset belongs.
            /// </summary>
            [NameInMap("Componentname")]
            [Validation(Required=false)]
            public string Componentname { get; set; }

            /// <summary>
            /// The time when the asset was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format and is displayed in UTC.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the asset was modified. The time is in the yyyy-MM-ddTHH:mm:ssZ format and is displayed in UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The configurations of the asset in the JSON string format. DescribeComponentAssetForm
            /// 
            /// >  For more information, see [DescribeComponentAssetForm](~~DescribeComponentAssetForm~~).
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
