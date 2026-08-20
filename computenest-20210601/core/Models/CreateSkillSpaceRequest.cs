// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateSkillSpaceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The value of ClientToken can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the SkillSpace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All-in-one office toolkit — generate reports, process data, manage files, and streamline workflows effortlessly.</para>
        /// </summary>
        [NameInMap("SkillSpaceDescription")]
        [Validation(Required=false)]
        public string SkillSpaceDescription { get; set; }

        /// <summary>
        /// <para>The name of the SkillSpace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>office-toolkit-skills</para>
        /// </summary>
        [NameInMap("SkillSpaceName")]
        [Validation(Required=false)]
        public string SkillSpaceName { get; set; }

    }

}
