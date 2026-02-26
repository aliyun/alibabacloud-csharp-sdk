// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartRemediationRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For information about how to obtain the rule ID, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-8a973ac2e2be00a2****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACS::VPC::VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
