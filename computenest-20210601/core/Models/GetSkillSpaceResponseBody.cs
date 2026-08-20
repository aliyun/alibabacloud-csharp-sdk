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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>13FE89A5-C036-56BF-A0FF-A31C59819FD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SkillSpace description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All-in-one office toolkit — generate reports, process data, manage files, and streamline workflows effortlessly.</para>
        /// </summary>
        [NameInMap("SkillSpaceDescription")]
        [Validation(Required=false)]
        public string SkillSpaceDescription { get; set; }

        /// <summary>
        /// <para>SkillSpace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-xxxxx</para>
        /// </summary>
        [NameInMap("SkillSpaceId")]
        [Validation(Required=false)]
        public string SkillSpaceId { get; set; }

        /// <summary>
        /// <para>The SkillSpace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>office-toolkit-skills</para>
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
