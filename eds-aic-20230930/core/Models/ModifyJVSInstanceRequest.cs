// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyJVSInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to apply the configuration to all instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ApplyToAll")]
        [Validation(Required=false)]
        public bool? ApplyToAll { get; set; }

        /// <summary>
        /// <para>The credit limit configuration. New configurations overwrite existing ones.</para>
        /// </summary>
        [NameInMap("CreditConfig")]
        [Validation(Required=false)]
        public List<ModifyJVSInstanceRequestCreditConfig> CreditConfig { get; set; }
        public class ModifyJVSInstanceRequestCreditConfig : TeaModel {
            /// <summary>
            /// <para>The credit limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CreditLimit")]
            [Validation(Required=false)]
            public long? CreditLimit { get; set; }

            /// <summary>
            /// <para>The credit limit period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("LimitPeriod")]
            [Validation(Required=false)]
            public string LimitPeriod { get; set; }

        }

        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The new instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultInstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

    }

}
