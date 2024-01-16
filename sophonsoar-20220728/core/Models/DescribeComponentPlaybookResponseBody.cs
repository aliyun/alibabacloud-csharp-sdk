// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentPlaybookResponseBody : TeaModel {
        /// <summary>
        /// The information about the predefined components.
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribeComponentPlaybookResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribeComponentPlaybookResponseBodyPlaybooks : TeaModel {
            /// <summary>
            /// The description of the predefined component.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the predefined component.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The input parameter configuration of the playbook. The value is a JSON array.
            /// 
            /// >  For more information, see [DescribePlaybookInputOutput](~~DescribePlaybookInputOutput~~).
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
