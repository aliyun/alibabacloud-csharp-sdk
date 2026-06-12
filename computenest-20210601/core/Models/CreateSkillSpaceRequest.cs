// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateSkillSpaceRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure the idempotence of the request. The token must be unique across requests. The <b>ClientToken</b> value can contain only ASCII characters and must be no more than 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the skill space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SkillSpaceDescription")]
        [Validation(Required=false)]
        public string SkillSpaceDescription { get; set; }

        /// <summary>
        /// <para>The name of the skill space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("SkillSpaceName")]
        [Validation(Required=false)]
        public string SkillSpaceName { get; set; }

    }

}
