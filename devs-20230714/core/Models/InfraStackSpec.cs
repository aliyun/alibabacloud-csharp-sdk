// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class InfraStackSpec : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("regionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("templateSpec")]
        [Validation(Required=false)]
        public InfraStackSpecTemplateSpec TemplateSpec { get; set; }
        public class InfraStackSpecTemplateSpec : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

        }

        [NameInMap("templateVariables")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateVariables { get; set; }

    }

}
