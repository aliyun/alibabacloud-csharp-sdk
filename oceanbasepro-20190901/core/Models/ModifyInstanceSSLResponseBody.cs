// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The SSL setting of the OceanBase cluster instance.</para>
        /// </summary>
        [NameInMap("InstanceSSL")]
        [Validation(Required=false)]
        public ModifyInstanceSSLResponseBodyInstanceSSL InstanceSSL { get; set; }
        public class ModifyInstanceSSLResponseBodyInstanceSSL : TeaModel {
            /// <summary>
            /// <para>The operation to modify the SSL status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>open: Enable SSL encryption.</para>
            /// </description></item>
            /// <item><description><para>update: Update the CA certificate.</para>
            /// </description></item>
            /// <item><description><para>close: Disable SSL encryption.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public string EnableSSL { get; set; }

            /// <summary>
            /// <para>The ID of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
