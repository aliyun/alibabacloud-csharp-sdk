// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListDigitalEmployeeSkillVersionsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDigitalEmployeeSkillVersionsResponseBodyData> Data { get; set; }
        public class ListDigitalEmployeeSkillVersionsResponseBodyData : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
