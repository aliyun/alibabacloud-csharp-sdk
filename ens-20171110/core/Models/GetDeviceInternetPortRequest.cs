// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetDeviceInternetPortRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can specify the ID of the server or container. You can specify only one ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5s6xbnx9srb3vm6tp9hg9o64e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway. The value must be of the enumerated data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SNAT</description></item>
        /// <item><description>DNAT</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNAT</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The ID of the rule. If you leave this parameter empty, all rules are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-5ref5fc1l1xgqnpjzrtw1hw5a</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
