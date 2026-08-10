// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyLangfuseSecurityIPListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyLangfuseSecurityIPListResponseBodyData Data { get; set; }
        public class ModifyLangfuseSecurityIPListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The Langfuse instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lfs-*****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the whitelist group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The group tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupTag")]
            [Validation(Required=false)]
            public string GroupTag { get; set; }

            /// <summary>
            /// <para>The IP whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/24,172.16.0.0/24</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The IP address type. The value is fixed to IPv4. IPv6 is not supported.</para>
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
            /// <para>100001080</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
