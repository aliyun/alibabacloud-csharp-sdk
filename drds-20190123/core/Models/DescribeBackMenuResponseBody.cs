// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackMenuResponseBody : TeaModel {
        /// <summary>
        /// The backup information list.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public DescribeBackMenuResponseBodyList List { get; set; }
        public class DescribeBackMenuResponseBodyList : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<DescribeBackMenuResponseBodyListList> List { get; set; }
            public class DescribeBackMenuResponseBodyListList : TeaModel {
                /// <summary>
                /// The backup method. Valid values:
                /// 
                /// *   **Logic **: logical backup
                /// *   **phy**: physical backup
                /// </summary>
                [NameInMap("MenuName")]
                [Validation(Required=false)]
                public string MenuName { get; set; }

                /// <summary>
                /// Indicates whether backup recovery is supported.
                /// </summary>
                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
