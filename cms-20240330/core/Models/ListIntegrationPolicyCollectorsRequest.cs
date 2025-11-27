// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyCollectorsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>release-1234567</para>
        /// </summary>
        [NameInMap("addonReleaseName")]
        [Validation(Required=false)]
        public string AddonReleaseName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exporter</para>
        /// </summary>
        [NameInMap("collectorType")]
        [Validation(Required=false)]
        public string CollectorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
