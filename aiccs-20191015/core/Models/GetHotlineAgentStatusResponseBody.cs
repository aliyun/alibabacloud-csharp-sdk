// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineAgentStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A value of &quot;Success&quot; indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Agent status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>Offline</b>  </description></item>
        /// <item><description><b>Idle</b>  </description></item>
        /// <item><description><b>Post-processing</b>  </description></item>
        /// <item><description><b>In Call</b>  </description></item>
        /// <item><description><b>Break - Rest</b>  </description></item>
        /// <item><description><b>Break - Meal</b>  </description></item>
        /// <item><description><b>Break - Meeting</b>  </description></item>
        /// <item><description><b>Break - Training</b>  </description></item>
        /// <item><description><b>Break - Coaching</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>通话中</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.  </description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
