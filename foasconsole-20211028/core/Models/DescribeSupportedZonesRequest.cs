// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeSupportedZonesRequest : TeaModel {
        /// <summary>
        /// <para>The processor architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
