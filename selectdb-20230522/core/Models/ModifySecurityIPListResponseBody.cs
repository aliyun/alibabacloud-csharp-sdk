// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifySecurityIPListResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the instance.</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The tag of the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptag</para>
        /// </summary>
        [NameInMap("GroupTag")]
        [Validation(Required=false)]
        public string GroupTag { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>195F64C2-8F11-532B-A436-FC08A221D756</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist of the instance. Multiple IP addresses are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.XX.XX,127.2.XX.XX</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The IP address type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>479095561</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The network type of the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mix</para>
        /// </summary>
        [NameInMap("WhitelistNetType")]
        [Validation(Required=false)]
        public string WhitelistNetType { get; set; }

    }

}
