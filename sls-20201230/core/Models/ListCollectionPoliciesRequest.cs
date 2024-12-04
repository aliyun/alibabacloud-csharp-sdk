// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>your-central-project1</para>
        /// </summary>
        [NameInMap("centralProject")]
        [Validation(Required=false)]
        public string CentralProject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>access_log</para>
        /// </summary>
        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your-test-bucket1</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your_log_policy</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
