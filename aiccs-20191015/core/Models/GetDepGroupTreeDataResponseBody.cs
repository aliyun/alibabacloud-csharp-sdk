// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetDepGroupTreeDataResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDepGroupTreeDataResponseBodyData> Data { get; set; }
        public class GetDepGroupTreeDataResponseBodyData : TeaModel {
            /// <summary>
            /// depGroupName
            /// </summary>
            [NameInMap("DepGroupName")]
            [Validation(Required=false)]
            public string DepGroupName { get; set; }

            /// <summary>
            /// depGroupId
            /// </summary>
            [NameInMap("DepGroupId")]
            [Validation(Required=false)]
            public string DepGroupId { get; set; }

            /// <summary>
            /// groupDTOS
            /// </summary>
            [NameInMap("GroupDTOS")]
            [Validation(Required=false)]
            public List<GetDepGroupTreeDataResponseBodyDataGroupDTOS> GroupDTOS { get; set; }
            public class GetDepGroupTreeDataResponseBodyDataGroupDTOS : TeaModel {
                /// <summary>
                /// skillGroupId
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public long? SkillGroupId { get; set; }

                /// <summary>
                /// name
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
