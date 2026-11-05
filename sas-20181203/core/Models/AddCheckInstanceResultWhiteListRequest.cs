// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCheckInstanceResultWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check group to which the check item belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cQFq20UzZ49K6gRSJD1301****</para>
        /// </summary>
        [NameInMap("CheckGroupId")]
        [Validation(Required=false)]
        public string CheckGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. A value of true indicates that only a dry run is performed and the actual operation is not performed. A value of false indicates that the actual operation is performed. Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance IDs of the assets.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The information about the asset instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<AddCheckInstanceResultWhiteListRequestInstanceList> InstanceList { get; set; }
        public class AddCheckInstanceResultWhiteListRequestInstanceList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// <remarks>
            /// <para>Invoke the <a href="~~ListCheckInstanceResult~~">ListCheckInstanceResult</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9fdluqx20mp2x7****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region where the asset resides.</para>
            /// <remarks>
            /// <para>Call the <a href="~~ListCheckInstanceResult~~">ListCheckInstanceResult</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The remarks. The value can be up to 65,535 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The type of the rule. Default value: <b>WHITE</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WHITE: Adds the instances to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
