// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyCheckInstanceResultResponseBodyData Data { get; set; }
        public class VerifyCheckInstanceResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array consisting of instances that failed the check.</para>
            /// </summary>
            [NameInMap("FailInstances")]
            [Validation(Required=false)]
            public List<string> FailInstances { get; set; }

            /// <summary>
            /// <para>The operation code of the task that checks the configurations of cloud services. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Throttling</b></description></item>
            /// <item><description><b>ActionTrialUnauthorized</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ActionTrialUnauthorized</para>
            /// </summary>
            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a410bb3-e68c217a-3368bc0-238c668***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B869E3A0-1147-539D-9920-47580700****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
