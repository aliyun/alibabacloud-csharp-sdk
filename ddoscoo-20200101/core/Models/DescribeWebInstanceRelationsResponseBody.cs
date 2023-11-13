// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebInstanceRelationsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the instances to which a website service is added.
        /// </summary>
        [NameInMap("WebInstanceRelations")]
        [Validation(Required=false)]
        public List<DescribeWebInstanceRelationsResponseBodyWebInstanceRelations> WebInstanceRelations { get; set; }
        public class DescribeWebInstanceRelationsResponseBodyWebInstanceRelations : TeaModel {
            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The information about the instance to which a website service is added.
            /// </summary>
            [NameInMap("InstanceDetails")]
            [Validation(Required=false)]
            public List<DescribeWebInstanceRelationsResponseBodyWebInstanceRelationsInstanceDetails> InstanceDetails { get; set; }
            public class DescribeWebInstanceRelationsResponseBodyWebInstanceRelationsInstanceDetails : TeaModel {
                /// <summary>
                /// The IP addresses of the instance.
                /// </summary>
                [NameInMap("EipList")]
                [Validation(Required=false)]
                public List<string> EipList { get; set; }

                /// <summary>
                /// The function plan of the instance. Valid values:
                /// 
                /// *   **default**: Standard function plan
                /// *   **enhance**: Enhanced function plan
                /// </summary>
                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
