// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceSSLRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public string EnableSSL { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
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

}
