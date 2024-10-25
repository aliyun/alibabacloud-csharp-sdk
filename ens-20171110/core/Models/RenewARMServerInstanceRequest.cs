// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RenewARMServerInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the premium bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>.</description></item>
        /// <item><description><b>false</b> (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the instance that you want to renew.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourInstance ID</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The renewal period. By default, instances are renewed on a monthly basis. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, and 12.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

    }

}
