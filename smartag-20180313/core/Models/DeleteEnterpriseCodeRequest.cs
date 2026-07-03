// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DeleteEnterpriseCodeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>The client generates the value of this parameter. Ensure that the value is unique among different requests. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The enterprise code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***</para>
        /// </summary>
        [NameInMap("EnterpriseCode")]
        [Validation(Required=false)]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> to query the regions supported by Smart Access Gateway and the corresponding region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
