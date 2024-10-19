// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyVpcAccessAndUpdateApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the associated API is updated, you can use the task ID in the <b>DescribeUpdateVpcInfoTask</b> operation to query the update result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7b6d0cb72b2e4215b0129f675c889746</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2CEC6EA-EEBA-5FD6-8BD9-2CF01980FE39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
