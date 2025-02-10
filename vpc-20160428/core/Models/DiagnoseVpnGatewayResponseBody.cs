// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DiagnoseVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic ID.</para>
        /// <para>After a diagnostic ID is returned, you can call <a href="https://help.aliyun.com/document_detail/2521963.html">GetVpnGatewayDiagnoseResult</a> to query the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpndgn-uf6kuxbe3iv028k3s****</para>
        /// </summary>
        [NameInMap("DiagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
