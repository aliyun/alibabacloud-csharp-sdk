// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyStorageRequirementsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the add-on release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-1234357</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>The name of the AddonRelease.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kafka-17201012937917</para>
        /// </summary>
        [NameInMap("addonReleaseName")]
        [Validation(Required=false)]
        public string AddonReleaseName { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values: LogStore, Prometheus, TraceStore, EventStore, and EntityStore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogStore</para>
        /// </summary>
        [NameInMap("storageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
