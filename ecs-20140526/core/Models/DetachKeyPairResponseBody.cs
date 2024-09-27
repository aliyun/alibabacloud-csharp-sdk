// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances from which the SSH key pair failed to be unbound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public string FailCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result set of the unbind operation.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public DetachKeyPairResponseBodyResults Results { get; set; }
        public class DetachKeyPairResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DetachKeyPairResponseBodyResultsResult> Result { get; set; }
            public class DetachKeyPairResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// <para>The operation status code that is returned. 200 indicates that the operation is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1d6tsvznfghy7y****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The result of the operation. For example, if the value of <c>Code</c> is 200, the value of <c>Message</c> is <c>successful</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of instances from which you want to unbind the SSH key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
