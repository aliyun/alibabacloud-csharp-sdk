// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeOperatorPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the permissions take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-02-25T03:35:02Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The time when the permissions expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-10T02:19:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The queried permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Control,Data</para>
        /// </summary>
        [NameInMap("Privileges")]
        [Validation(Required=false)]
        public string Privileges { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
