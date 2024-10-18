// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyBillingPublicRequest : TeaModel {
        /// <summary>
        /// <para>The verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: phone number verification</description></item>
        /// <item><description><b>1</b>: one-click logon</description></item>
        /// <item><description><b>2</b>: all</description></item>
        /// <item><description><b>3</b>: facial recognition</description></item>
        /// <item><description><b>4</b>: SMS verification</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public int? AuthenticationType { get; set; }

        /// <summary>
        /// <para>The month in which the bill is generated. Specify this parameter in the YYYYMM format. Example: 202111.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202111</para>
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public string Month { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
