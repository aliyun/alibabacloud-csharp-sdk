// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSlsLogStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wafng-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wafng-project-14316572********-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The capacity of the Logstore. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3298534883328</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAC0A24B-486A-5E12-9894-BE860E5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage duration of the Logstore. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The used capacity of the Logstore. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35471136</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

    }

}
