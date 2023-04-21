// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFrontVulPatchListResponseBody : TeaModel {
        /// <summary>
        /// Details about patches of one or more vulnerabilities before you fix the current vulnerability.
        /// </summary>
        [NameInMap("FrontPatchList")]
        [Validation(Required=false)]
        public List<DescribeFrontVulPatchListResponseBodyFrontPatchList> FrontPatchList { get; set; }
        public class DescribeFrontVulPatchListResponseBodyFrontPatchList : TeaModel {
            /// <summary>
            /// The ID of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// Details about patches.
            /// </summary>
            [NameInMap("PatchList")]
            [Validation(Required=false)]
            public List<DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList> PatchList { get; set; }
            public class DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList : TeaModel {
                /// <summary>
                /// The alias of the vulnerability.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// The name of the vulnerability.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
