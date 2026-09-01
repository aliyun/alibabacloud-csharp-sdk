// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddAssetSelectionCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests should use different tokens. The token supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The conditions for searching assets. This parameter is in JSON format. Pay attention to the letter case when you specify this parameter.</para>
        /// <remarks>
        /// <para>You can search for assets by instance ID, instance name, VPC ID, region, public IP address, and other conditions. Call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LogicalExp&quot;:&quot;AND&quot;,&quot;Criteria&quot;:&quot;[{\&quot;name\&quot;:\&quot;osType\&quot;,\&quot;value\&quot;:\&quot;linux\&quot;,\&quot;logicalExp\&quot;:\&quot;AND\&quot;},{\&quot;name\&quot;:\&quot;alarmStatus\&quot;,\&quot;value\&quot;:\&quot;YES\&quot;,\&quot;logicalExp\&quot;:\&quot;AND\&quot;}]&quot;}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The operation type for criteria. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: adds assets.</description></item>
        /// <item><description><b>del</b>: deletes assets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("CriteriaOperation")]
        [Validation(Required=false)]
        public string CriteriaOperation { get; set; }

        /// <summary>
        /// <para>The unique identifier of the asset selection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5196d280-5bfa-496a-ba70-8a3935e3****</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        /// <summary>
        /// <para>The list of assets.</para>
        /// </summary>
        [NameInMap("TargetOperationList")]
        [Validation(Required=false)]
        public List<AddAssetSelectionCriteriaRequestTargetOperationList> TargetOperationList { get; set; }
        public class AddAssetSelectionCriteriaRequestTargetOperationList : TeaModel {
            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: adds the asset.</description></item>
            /// <item><description><b>del</b>: deletes the asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>del</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The asset ID. If you select assets by machine, the value is the UUID of the machine. If you select assets by group, the value is the group ID. If you select assets by VPC, the value is the VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1188****</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

        }

    }

}
