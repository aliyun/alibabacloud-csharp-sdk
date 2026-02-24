// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetDigitalEmployeeSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T14:09:11Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GetDigitalEmployeeSkillResponseBodyFiles> Files { get; set; }
        public class GetDigitalEmployeeSkillResponseBodyFiles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// <h2>name: skill
            /// description: description</h2>
            /// <h1>skill</h1>
            /// <para>skill test</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SKILL.md</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("skillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-06T14:09:11Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1770386951147366810</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
