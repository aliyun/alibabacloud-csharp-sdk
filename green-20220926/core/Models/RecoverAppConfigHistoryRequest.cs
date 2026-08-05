// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class RecoverAppConfigHistoryRequest : TeaModel {
        /// <summary>
        /// <para>App ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt_check_agent_01</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1785898163</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public long? AppVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
