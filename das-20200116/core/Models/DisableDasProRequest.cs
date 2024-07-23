// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableDasProRequest : TeaModel {
        /// <summary>
        /// <para>The database instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
        /// <remarks>
        /// <para> This parameter is optional. The system can automatically obtain the account ID based on the value of InstanceId that you set when you call this operation.</para>
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
