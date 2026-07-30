// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DeleteStopGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the database gateway.</para>
        /// <para>Note: You can get this ID from the <c>ClientGatewayId</c> field in the response of the <a href="https://help.aliyun.com/document_detail/230669.html">DescribeCloudbenchTask</a>  API.</para>
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
