// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AddRCInstancesToDeploymentSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08A3B71B-FE08-4B03-974F-CC7EA6DB1828</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The inspection results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AddRCInstancesToDeploymentSetResponseBodyResults> Results { get; set; }
        public class AddRCInstancesToDeploymentSetResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>activation</b>: Running.</description></item>
            /// <item><description><b>creating</b>: Being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-aaaa</para>
            /// </summary>
            [NameInMap("RCInstanceId")]
            [Validation(Required=false)]
            public string RCInstanceId { get; set; }

            /// <summary>
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: Succeeded.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
