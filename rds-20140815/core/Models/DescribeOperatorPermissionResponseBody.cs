// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeOperatorPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The effective period of the authorization. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12T02:27:04Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the authorization expires. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2030-01-01T11:58:17Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The types of permissions that are granted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Control</b>: configuration permissions. Allows you to view and modify instance configurations.</description></item>
        /// <item><description><b>Data</b>: database permissions. Allows you to view table schemas, indexes, and SQL statements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Control,Data</para>
        /// </summary>
        [NameInMap("Privileges")]
        [Validation(Required=false)]
        public string Privileges { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C3535DC-743E-505A-B4F6-ABC***75C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
