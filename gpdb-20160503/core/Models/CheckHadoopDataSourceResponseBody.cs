// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CheckHadoopDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned by the service. If the service is unavailable, an error message is returned. If the service is available, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serivce unavaliable</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Running: The service is available.</para>
        /// </description></item>
        /// <item><description><para>Failed: The service is unavailable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
