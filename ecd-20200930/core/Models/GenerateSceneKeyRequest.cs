// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GenerateSceneKeyRequest : TeaModel {
        /// <summary>
        /// <para>The Cloud Desktop ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The validity period of the key, in hours. A value of 0 indicates that the key never expires. If this parameter is not specified, the default value on the server is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentGateway</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
