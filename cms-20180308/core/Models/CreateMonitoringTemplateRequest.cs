// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class CreateMonitoringTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertTemplatesJson")]
        [Validation(Required=false)]
        public string AlertTemplatesJson { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HostAvailabilityTemplate")]
        [Validation(Required=false)]
        public string HostAvailabilityTemplate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ProcessMonitorTemplates")]
        [Validation(Required=false)]
        public string ProcessMonitorTemplates { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SystemEventTemplates")]
        [Validation(Required=false)]
        public string SystemEventTemplates { get; set; }

    }

}
