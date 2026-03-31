// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteRemediationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("RemediationDeleteResults")]
        [Validation(Required=false)]
        public List<DeleteRemediationsResponseBodyRemediationDeleteResults> RemediationDeleteResults { get; set; }
        public class DeleteRemediationsResponseBodyRemediationDeleteResults : TeaModel {
            /// <summary>
            /// <para>The error code returned.</para>
            /// <list type="bullet">
            /// <item><description>If the remediation template is deleted, no error code is returned.</description></item>
            /// <item><description>If the remediation template fails to be deleted, an error code is returned. For more information about error codes, see <a href="https://error-center.alibabacloud.com/status/product/Config">Error codes</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RemediationConfigNotExist</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-909ba2d4716700eb****</para>
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The request was successful.</description></item>
            /// <item><description>false: The request failed.</description></item>
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
