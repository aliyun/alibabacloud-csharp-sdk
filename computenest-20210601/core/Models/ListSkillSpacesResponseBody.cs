// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillSpacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D550C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of SkillSpaces.</para>
        /// </summary>
        [NameInMap("SkillSpaces")]
        [Validation(Required=false)]
        public List<ListSkillSpacesResponseBodySkillSpaces> SkillSpaces { get; set; }
        public class ListSkillSpacesResponseBodySkillSpaces : TeaModel {
            /// <summary>
            /// <para>The time when the SkillSpace was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-03T22:58:52Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the SkillSpace.</para>
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
            /// <para>The name of the SkillSpace.</para>
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
            /// <para>2025-11-03T22:57:29Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
