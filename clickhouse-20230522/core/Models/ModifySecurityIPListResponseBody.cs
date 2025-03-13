// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifySecurityIPListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifySecurityIPListResponseBodyData Data { get; set; }
        public class ModifySecurityIPListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxx</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxx</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The tag of the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupTag")]
            [Validation(Required=false)]
            public string GroupTag { get; set; }

            /// <summary>
            /// <para>The IP addresses and CIDR blocks in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/24,172.16.0.0/24</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
