// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateAiAppScanStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application IDs that failed.</para>
        /// </summary>
        [NameInMap("FailedAppIds")]
        [Validation(Required=false)]
        public List<string> FailedAppIds { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SUCCESS: Succeeded.</para>
        /// </description></item>
        /// <item><description><para>PARTIAL_SUCCESS: Partially succeeded.</para>
        /// </description></item>
        /// <item><description><para>FAILED: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of application IDs that succeeded.</para>
        /// </summary>
        [NameInMap("SuccessAppIds")]
        [Validation(Required=false)]
        public List<string> SuccessAppIds { get; set; }

    }

}
