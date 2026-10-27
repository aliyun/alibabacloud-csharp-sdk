// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class EnableDasProRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The storage duration of SQL Explorer data. Unit: days. Default value: <b>30</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>180</b></description></item>
        /// <item><description><b>365</b></description></item>
        /// <item><description><b>1095</b></description></item>
        /// <item><description><b>1825</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SqlRetention")]
        [Validation(Required=false)]
        public int? SqlRetention { get; set; }

        /// <summary>
        /// <para>The instance ID, which is the ID of the Alibaba Cloud account that created the database instance.</para>
        /// <remarks>
        /// <para>This parameter is optional. After you specify the ID of the target database instance, the system automatically obtains the instance ID when you call the API operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>196278346919****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
