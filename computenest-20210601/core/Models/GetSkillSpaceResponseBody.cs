// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetSkillSpaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the SkillSpace was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13FE89A5-C036-56BF-A0FF-A31C59819FD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The description of the SkillSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("SkillSpaceDescription")]
        [Validation(Required=false)]
        public string SkillSpaceDescription { get; set; }

        /// <summary>
        /// <para>The ID of the SkillSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-11111</para>
        /// </summary>
        [NameInMap("SkillSpaceId")]
        [Validation(Required=false)]
        public string SkillSpaceId { get; set; }

        /// <summary>
        /// <para>The name of the SkillSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("SkillSpaceName")]
        [Validation(Required=false)]
        public string SkillSpaceName { get; set; }

        /// <summary>
        /// <para>The time when the SkillSpace was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
