// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances from which the key pair failed to be detached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// <para>The ID of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssh-xxx</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssh-xxx</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx-xx-xx-xx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results indicating whether the key pair was successfully or unsuccessfully detached from the instances.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachKeyPairResponseBodyResults> Results { get; set; }
        public class AttachKeyPairResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The status code of the operation. A value of 200 indicates that the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The message returned for the operation. If the code is 200, the message is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The total number of instances from which the key pair was detached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
