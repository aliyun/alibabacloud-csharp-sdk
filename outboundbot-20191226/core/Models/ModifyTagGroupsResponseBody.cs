// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyTagGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5a865b03-d2b9-4ef9-be98-f21fa0d93744</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TagGroups")]
        [Validation(Required=false)]
        public List<ModifyTagGroupsResponseBodyTagGroups> TagGroups { get; set; }
        public class ModifyTagGroupsResponseBodyTagGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>365b955d-6f4d-4ab5-a6e1-9a301307f4b1</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>54629be9-0746-464a-ab59-4830242cf644</para>
            /// </summary>
            [NameInMap("TagGroupId")]
            [Validation(Required=false)]
            public string TagGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ModifyTagGroupsResponseBodyTags> Tags { get; set; }
        public class ModifyTagGroupsResponseBodyTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>365b955d-6f4d-4ab5-a6e1-9a301307f4b1</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19b23e92-4ee3-4129-8c2e-e1968670d887</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagIndex")]
            [Validation(Required=false)]
            public int? TagIndex { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
