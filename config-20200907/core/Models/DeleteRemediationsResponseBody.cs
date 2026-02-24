// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteRemediationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the delete operation.</para>
        /// </summary>
        [NameInMap("RemediationDeleteResults")]
        [Validation(Required=false)]
        public List<DeleteRemediationsResponseBodyRemediationDeleteResults> RemediationDeleteResults { get; set; }
        public class DeleteRemediationsResponseBodyRemediationDeleteResults : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is empty if the remediation setting is successfully deleted.</para>
            /// </description></item>
            /// <item><description><para>This parameter returns an error code if the operation fails. For more information about error codes, see &lt;props=&quot;intl&quot;&gt;<a href="https://error-center.alibabacloud.com/status/product/Config">Error Center</a>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RemediationConfigNotExist</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The remediation setting ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-909ba2d4716700eb****</para>
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The operation was successful.</para>
            /// </description></item>
            /// <item><description><para>false: The operation failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4BE28FB1-616A-5586-82E4-F34FB2AF7441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
