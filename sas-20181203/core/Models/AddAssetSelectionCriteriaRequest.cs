// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddAssetSelectionCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions that are used to query assets. The value of this parameter is in the JSON format and is case-sensitive.</para>
        /// <remarks>
        /// <para>A search condition can be an instance ID, instance name, virtual private cloud (VPC) ID, region, or public IP address. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LogicalExp&quot;:&quot;AND&quot;,&quot;Criteria&quot;:&quot;[{\&quot;name\&quot;:\&quot;osType\&quot;,\&quot;value\&quot;:\&quot;linux\&quot;,\&quot;logicalExp\&quot;:\&quot;AND\&quot;},{\&quot;name\&quot;:\&quot;alarmStatus\&quot;,\&quot;value\&quot;:\&quot;YES\&quot;,\&quot;logicalExp\&quot;:\&quot;AND\&quot;}]&quot;}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The type of the operation on search conditions. Valid values:</para>
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
        /// <para>The unique ID of the asset.</para>
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
            /// <para>The type of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b></description></item>
            /// <item><description><b>del</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>del</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The ID of the asset.</para>
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
