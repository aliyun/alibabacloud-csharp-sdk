// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DeleteStopGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The ID that can uniquely identify the DBGateway. You can obtain the DBGateway ID by calling the <a href="https://help.aliyun.com/document_detail/230669.html">DescribeCloudbenchTask</a> operation. The DBGateway ID is the value of the <b>ClientGatewayId</b> field in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22938c83fcfbced4b4869b9695e3****</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

    }

}
