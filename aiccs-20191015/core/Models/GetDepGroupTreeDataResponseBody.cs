// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetDepGroupTreeDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDepGroupTreeDataResponseBodyData> Data { get; set; }
        public class GetDepGroupTreeDataResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DepGroupId")]
            [Validation(Required=false)]
            public string DepGroupId { get; set; }

            [NameInMap("DepGroupName")]
            [Validation(Required=false)]
            public string DepGroupName { get; set; }

            [NameInMap("GroupDTOS")]
            [Validation(Required=false)]
            public List<GetDepGroupTreeDataResponseBodyDataGroupDTOS> GroupDTOS { get; set; }
            public class GetDepGroupTreeDataResponseBodyDataGroupDTOS : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>555555</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public long? SkillGroupId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
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
        public string Success { get; set; }

    }

}
