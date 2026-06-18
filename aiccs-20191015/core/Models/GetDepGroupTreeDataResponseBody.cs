// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetDepGroupTreeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of Success indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Department information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDepGroupTreeDataResponseBodyData> Data { get; set; }
        public class GetDepGroupTreeDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10****</para>
            /// </summary>
            [NameInMap("DepGroupId")]
            [Validation(Required=false)]
            public string DepGroupId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>部门A</para>
            /// </summary>
            [NameInMap("DepGroupName")]
            [Validation(Required=false)]
            public string DepGroupName { get; set; }

            /// <summary>
            /// <para>Skill group data.</para>
            /// </summary>
            [NameInMap("GroupDTOS")]
            [Validation(Required=false)]
            public List<GetDepGroupTreeDataResponseBodyDataGroupDTOS> GroupDTOS { get; set; }
            public class GetDepGroupTreeDataResponseBodyDataGroupDTOS : TeaModel {
                /// <summary>
                /// <para>The name of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自动化技能组</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55****</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public long? SkillGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
