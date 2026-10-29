// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeOperatorPermissionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-10-12T02:27:04Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2030-01-01T11:58:17Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Control,Data</para>
        /// </summary>
        [NameInMap("Privileges")]
        [Validation(Required=false)]
        public string Privileges { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C3535DC-743E-505A-B4F6-ABC***75C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
