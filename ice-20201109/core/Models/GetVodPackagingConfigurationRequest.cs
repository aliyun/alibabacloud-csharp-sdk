// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetVodPackagingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the packaging configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls_3s</para>
        /// </summary>
        [NameInMap("ConfigurationName")]
        [Validation(Required=false)]
        public string ConfigurationName { get; set; }

    }

}
