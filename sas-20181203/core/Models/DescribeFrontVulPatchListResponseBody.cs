// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFrontVulPatchListResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the information about the pre-patches that are required to fix the specified Windows system vulnerability.
        /// </summary>
        [NameInMap("FrontPatchList")]
        [Validation(Required=false)]
        public List<DescribeFrontVulPatchListResponseBodyFrontPatchList> FrontPatchList { get; set; }
        public class DescribeFrontVulPatchListResponseBodyFrontPatchList : TeaModel {
            /// <summary>
            /// An array consisting of the pre-patches that are required to fix the specified Windows system vulnerability on the server.
            /// </summary>
            [NameInMap("PatchList")]
            [Validation(Required=false)]
            public List<DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList> PatchList { get; set; }
            public class DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList : TeaModel {
                /// <summary>
                /// The name of the vulnerability.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// The version number of the pre-patch that is required to fix the Windows system vulnerability.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
