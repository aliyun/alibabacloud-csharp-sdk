// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyStorageRequirementsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>release-1234357</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        [NameInMap("addonReleaseName")]
        [Validation(Required=false)]
        public string AddonReleaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LogStore</para>
        /// </summary>
        [NameInMap("storageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
