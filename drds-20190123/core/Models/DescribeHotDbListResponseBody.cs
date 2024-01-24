// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeHotDbListResponseBody : TeaModel {
        /// <summary>
        /// The result that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotDbListResponseBodyData Data { get; set; }
        public class DescribeHotDbListResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the databases on which hot-spot scale-out is performed.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public DescribeHotDbListResponseBodyDataList List { get; set; }
            public class DescribeHotDbListResponseBodyDataList : TeaModel {
                [NameInMap("InstanceDb")]
                [Validation(Required=false)]
                public List<DescribeHotDbListResponseBodyDataListInstanceDb> InstanceDb { get; set; }
                public class DescribeHotDbListResponseBodyDataListInstanceDb : TeaModel {
                    [NameInMap("HotDbList")]
                    [Validation(Required=false)]
                    public DescribeHotDbListResponseBodyDataListInstanceDbHotDbList HotDbList { get; set; }
                    public class DescribeHotDbListResponseBodyDataListInstanceDbHotDbList : TeaModel {
                        [NameInMap("data")]
                        [Validation(Required=false)]
                        public List<string> Data { get; set; }

                    }

                    /// <summary>
                    /// The name of the instance.
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                }

            }

            /// <summary>
            /// The random number.
            /// </summary>
            [NameInMap("RandomCode")]
            [Validation(Required=false)]
            public string RandomCode { get; set; }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
