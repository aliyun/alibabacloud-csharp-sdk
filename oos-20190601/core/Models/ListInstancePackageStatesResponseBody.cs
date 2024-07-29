// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePackageStatesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PackageStates")]
        [Validation(Required=false)]
        public List<ListInstancePackageStatesResponseBodyPackageStates> PackageStates { get; set; }
        public class ListInstancePackageStatesResponseBodyPackageStates : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public string Publisher { get; set; }

            [NameInMap("TemplateCategory")]
            [Validation(Required=false)]
            public string TemplateCategory { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            [NameInMap("TemplateVersionName")]
            [Validation(Required=false)]
            public string TemplateVersionName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
