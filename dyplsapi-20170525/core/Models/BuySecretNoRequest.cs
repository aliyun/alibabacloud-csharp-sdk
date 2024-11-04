// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BuySecretNoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the home location of the phone number.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The home location can be set only to a location in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>A phone number that starts with 95 does not have a home location. If you purchase a phone number that starts with 95, set this parameter to <b>Nationwide</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the phone number to the pool of numbers that will be displayed during calls.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for customers who have enabled the number display feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayPool")]
        [Validation(Required=false)]
        public bool? DisplayPool { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC123456</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The prefix of the phone number. If you specify the value of <b>SecretNo</b> when you purchase a phone number, a phone number starting with the specified prefix is selected.</para>
        /// <remarks>
        /// <para> You can specify up to 18 digits of the phone number prefix.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>130</para>
        /// </summary>
        [NameInMap("SecretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

        /// <summary>
        /// <para>The type of the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: a phone number assigned by a virtual network operator, that is, a phone number that belongs to the 170 or 171 number segment.</description></item>
        /// <item><description><b>2</b>: a phone number provided by a carrier.</description></item>
        /// <item><description><b>3</b>: a phone number that starts with 95.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public long? SpecId { get; set; }

    }

}
