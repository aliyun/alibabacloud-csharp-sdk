// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListPatchBaselinesRequest : TeaModel {
        [NameInMap("ApprovedPatches")]
        [Validation(Required=false)]
        public List<string> ApprovedPatches { get; set; }

        [NameInMap("ApprovedPatchesEnableNonSecurity")]
        [Validation(Required=false)]
        public bool? ApprovedPatchesEnableNonSecurity { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The share type of the patch baseline.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("OperationSystem")]
        [Validation(Required=false)]
        public string OperationSystem { get; set; }

        /// <summary>
        /// The type of the operating system. Valid values:
        /// 
        /// *   AliyunLinux
        /// *   Windows
        /// *   Ubuntu
        /// *   Centos
        /// *   Debian
        /// *   RedhatEnterpriseLinux
        /// *   Anolis
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupld")]
        [Validation(Required=false)]
        public string ResourceGroupld { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<string> Sources { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPatchBaselinesRequestTags> Tags { get; set; }
        public class ListPatchBaselinesRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
