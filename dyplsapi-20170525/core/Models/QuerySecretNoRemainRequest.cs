// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoRemainRequest : TeaModel {
        /// <summary>
        /// <para>The home location of the phone number.</para>
        /// <list type="bullet">
        /// <item><description>If <b>SpecId</b> is set to 1 or 2, you can specify the <b>City</b> parameter to query the quantity of available phone numbers.</description></item>
        /// </list>
        /// <ol>
        /// <item><description>You can enter a single city name to perform a query.</description></item>
        /// <item><description>You can enter National to query the quantity of remaining phone numbers available in the Chinese mainland for online purchase.</description></item>
        /// <item><description>You can enter National List to query the cities with available phone numbers and the quantities of remaining phone numbers in the Chinese mainland. Cities without available phone numbers will not be returned.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If <b>SpecId</b> is set to 3, home locations are not distinguished for phone numbers that start with 95 and only the quantity of all the remaining phone numbers that start with 95 and are available for online purchase can be queried. If SpecId is set to 3, <b>City</b> must be set to <b>Nationwide</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Home locations can be set to only locations in the Chinese mainland.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The prefix of the phone number. When you call the QuerySecretNoRemain operation with <b>SecretNo</b> specified, the quantity of remaining phone numbers with the specified prefix that are available for online purchase is queried.</para>
        /// <para>Up to 18 digits of a phone number prefix can be specified.</para>
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
