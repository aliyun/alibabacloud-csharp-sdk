// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The handling result code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Insufficient authorization: AuthorizationExhaust</description></item>
        /// <item><description>Unauthorized: ActionTrialUnauthorized</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AuthorizationExhaust</para>
        /// </summary>
        [NameInMap("OperateCode")]
        [Validation(Required=false)]
        public string OperateCode { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C8487EF-50C2-54BB-8634-10F8C35D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The main task ID that is returned when the task is submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89f5d7813bd59dd237580a8664b3xxxx</para>
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

    }

}
