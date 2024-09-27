// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The synchronized expiration date. Set the value to a synchronized expiration date that you specified. Otherwise, the call fails. If you configure this parameter, your instance will be renewed to the specified synchronized expiration date. Valid values: 1 to 28.</para>
        /// <para>For information about how to synchronize the expiration dates of instances, see <a href="https://help.aliyun.com/document_detail/108486.html">Synchronize the expiration dates of subscription instances</a>.</para>
        /// <remarks>
        /// <para>The renewal period-related parameter pair (<c>Period</c> and <c>PeriodUnit</c>) and <c>ExpectedRenewDay</c> are mutually exclusive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExpectedRenewDay")]
        [Validation(Required=false)]
        public int? ExpectedRenewDay { get; set; }

        /// <summary>
        /// <para>The ID of the instance that you want to renew.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The renewal period of the subscription instance. If <c>DedicatedHostId</c> is specified, the value of Period cannot exceed the subscription period of the specified dedicated host.</para>
        /// <para>Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, and 12.</para>
        /// <remarks>
        /// <para>The renewal period-related parameter pair (<c>Period</c> and <c>PeriodUnit</c>) and <c>ExpectedRenewDay</c> are mutually exclusive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal period. Valid values:</para>
        /// <para>Month</para>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
