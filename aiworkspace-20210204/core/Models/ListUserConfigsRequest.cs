// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListUserConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The category. Only DataPrivacyConfig is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataPrivacyConfig</para>
        /// </summary>
        [NameInMap("CategoryNames")]
        [Validation(Required=false)]
        public string CategoryNames { get; set; }

        /// <summary>
        /// <para>A collection of configuration keys. Only customizePAIAssumedRole is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customizePAIAssumedRole</para>
        /// </summary>
        [NameInMap("ConfigKeys")]
        [Validation(Required=false)]
        public string ConfigKeys { get; set; }

    }

}
