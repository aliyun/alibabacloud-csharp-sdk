// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CheckSampleDataSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CE655C3-C211-513D-A42F-D4AE2D1A867C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the built-in dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SUCCEED</b>: The dataset loaded successfully.</para>
        /// </description></item>
        /// <item><description><para><b>INIT</b>: Loading in progress.</para>
        /// </description></item>
        /// <item><description><para><b>FAILED</b>: Failed to load the dataset.</para>
        /// </description></item>
        /// <item><description><para><b>UNINITIALIZED</b>: Not loaded.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UNINITIALIZED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
