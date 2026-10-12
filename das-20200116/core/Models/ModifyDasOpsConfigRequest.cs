// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifyDasOpsConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable DAS Alibaba Cloud Managed Services. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled. Note that shutdown only disables the feature, but does not cancel your subscription. To cancel your subscription, go to the Unsubscription Management page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ModifyDasOpsConfigRequestFilters> Filters { get; set; }
        public class ModifyDasOpsConfigRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter parameter.</para>
            /// <remarks>
            /// <para>For supported filter parameters and their valid values, see <b>Supplementary description of request parameters</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The database instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-uf6079bda570****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
