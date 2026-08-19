// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAIImageInfosRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of AI image information. This parameter consists of one or more AIImageInfoId values. The AIImageInfoId is the value of the AIImageInfoId response parameter returned by the <a href="https://help.aliyun.com/document_detail/186924.html">ListAIImageInfo</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>A maximum of 10 IDs are supported.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b89a6aabf144*****6197ebd6fe6cf29</para>
        /// </summary>
        [NameInMap("AIImageInfoIds")]
        [Validation(Required=false)]
        public string AIImageInfoIds { get; set; }

    }

}
