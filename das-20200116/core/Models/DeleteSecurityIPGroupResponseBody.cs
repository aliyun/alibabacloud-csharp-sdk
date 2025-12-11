// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DeleteSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>ListResult<InstanceSSL></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSecurityIPGroupResponseBodyData Data { get; set; }
        public class DeleteSecurityIPGroupResponseBodyData : TeaModel {
            [NameInMap("GlobalSecurityIPGroup")]
            [Validation(Required=false)]
            public List<DeleteSecurityIPGroupResponseBodyDataGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
            public class DeleteSecurityIPGroupResponseBodyDataGlobalSecurityIPGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>g-1no2rzybnqcv0m****</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
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
