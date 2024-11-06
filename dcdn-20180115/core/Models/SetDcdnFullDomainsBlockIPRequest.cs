// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnFullDomainsBlockIPRequest : TeaModel {
        /// <summary>
        /// <para>The duration for which IP addresses or CIDR blocks are blocked. Unit: seconds. The value <b>0</b> specifies that IP addresses or CIDR blocks are permanently blocked. This parameter is available only if you set <b>OperationType</b> to <b>block</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("BlockInterval")]
        [Validation(Required=false)]
        public int? BlockInterval { get; set; }

        /// <summary>
        /// <para>The IP addresses that you want to block or unblock. Separate multiple IP addresses with commas (,). You can specify up to 1,000 IP addresses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.XXX.XXX.1,2.XXX.XXX.2</para>
        /// </summary>
        [NameInMap("IPList")]
        [Validation(Required=false)]
        public string IPList { get; set; }

        /// <summary>
        /// <para>The action that you want to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b></description></item>
        /// <item><description><b>unblock</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The type of the blocking duration. This parameter is available only if you set <b>OperationType</b> to <b>block</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cover</b>: the blocking duration that is specified in the request takes effect.</description></item>
        /// <item><description><b>uncover</b>: the longer one of the blocking duration that is specified in the request and the remaining blocking duration takes effect.</description></item>
        /// <item><description>Default value: cover.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cover</para>
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
