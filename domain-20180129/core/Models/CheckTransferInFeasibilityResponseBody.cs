// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckTransferInFeasibilityResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the domain name can be transferred in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The domain name can be transferred in.</description></item>
        /// <item><description><b>false</b>: The domain name cannot be transferred in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanTransfer")]
        [Validation(Required=false)]
        public bool? CanTransfer { get; set; }

        /// <summary>
        /// <para>The error code returned when the domain name cannot be transferred in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckTransferResult.DomainTransferProhibited</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error description returned when the domain name cannot be transferred in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This domain name is in transfer prohibited status, so it cannot be transferred. You can contact your original registrar to change its status.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The product ID of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2a</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC0D6B89-2353-4D64-BD80-6606A7DBD7C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
