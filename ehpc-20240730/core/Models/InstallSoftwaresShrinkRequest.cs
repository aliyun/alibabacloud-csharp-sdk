// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class InstallSoftwaresShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The information about the software systems that you want to install.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
