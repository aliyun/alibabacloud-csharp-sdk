// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplication : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InternetURL")]
        [Validation(Required=false)]
        public string InternetURL { get; set; }

        [NameInMap("IntranetURL")]
        [Validation(Required=false)]
        public string IntranetURL { get; set; }

        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

        [NameInMap("WebTrafficConfig")]
        [Validation(Required=false)]
        public WebTrafficConfig WebTrafficConfig { get; set; }

    }

}
