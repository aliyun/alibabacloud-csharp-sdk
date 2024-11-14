// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeSecurityIPListResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The details about each IP address whitelist returned.</para>
        /// </summary>
        [NameInMap("GroupItems")]
        [Validation(Required=false)]
        public List<DescribeSecurityIPListResponseBodyGroupItems> GroupItems { get; set; }
        public class DescribeSecurityIPListResponseBodyGroupItems : TeaModel {
            /// <summary>
            /// <para>The IP address type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ipv4</description></item>
            /// <item><description>ipv6 (not supported)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("AecurityIPType")]
            [Validation(Required=false)]
            public string AecurityIPType { get; set; }

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
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("GroupTag")]
            [Validation(Required=false)]
            public string GroupTag { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist. Multiple IP addresses are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.XX.XX</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

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
        /// <para>5CBE044D-4594-525D-AC65-E988553D853E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
