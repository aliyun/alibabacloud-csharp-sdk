// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class InstallSoftwaresRequest : TeaModel {
        /// <summary>
        /// <para>The information about the software systems that you want to install.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public List<InstallSoftwaresRequestAdditionalPackages> AdditionalPackages { get; set; }
        public class InstallSoftwaresRequestAdditionalPackages : TeaModel {
            /// <summary>
            /// <para>The software name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gromacs</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The software version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024.1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

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
