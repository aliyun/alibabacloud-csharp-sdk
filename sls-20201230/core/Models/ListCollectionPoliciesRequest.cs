// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The destination project for centralized data shipping. Specify this parameter to query the number of rules that are configured to ship data to this project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-central-project1</para>
        /// </summary>
        [NameInMap("centralProject")]
        [Validation(Required=false)]
        public string CentralProject { get; set; }

        /// <summary>
        /// <para>The code of the log type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>access_log</para>
        /// </summary>
        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        /// <summary>
        /// <para>The instance ID. Specify this parameter to query rules that match a specific instance. If you use this parameter, you must also specify productCode and dataCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-test-bucket1</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The row from which the query starts. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The name of the collection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_log_policy</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The code of the Alibaba Cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The number of collection rules to return on each page. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
