// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetAuditLogStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AuditLogStatus")]
        [Validation(Required=false)]
        public string AuditLogStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bucket-test</para>
        /// </summary>
        [NameInMap("AuditOssBucket")]
        [Validation(Required=false)]
        public string AuditOssBucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GrantedServiceAccess")]
        [Validation(Required=false)]
        public bool? GrantedServiceAccess { get; set; }

        [NameInMap("OssBuckets")]
        [Validation(Required=false)]
        public List<string> OssBuckets { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
