// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>345</para>
        /// </summary>
        [NameInMap("AttackCnt")]
        [Validation(Required=false)]
        public string AttackCnt { get; set; }

        [NameInMap("AttackerList")]
        [Validation(Required=false)]
        public List<string> AttackerList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;location\&quot;:[\&quot;FR\&quot;,\&quot;CN\&quot;],\&quot;location_type\&quot;:\&quot;country\&quot;}</para>
        /// </summary>
        [NameInMap("DetailValue")]
        [Validation(Required=false)]
        public string DetailValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683703260</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18ba94fea9***e66ba0557b7b91</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ObtainSensitiveUnauthorized</para>
        /// </summary>
        [NameInMap("EventTag")]
        [Validation(Required=false)]
        public string EventTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>already confirmed.</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683648000</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public string StartTs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>toBeConfirmed</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
