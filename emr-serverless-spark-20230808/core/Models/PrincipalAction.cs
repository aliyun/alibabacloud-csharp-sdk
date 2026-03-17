// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class PrincipalAction : TeaModel {
        /// <summary>
        /// <para>The ARN of the behavior.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:emr::workspaceId:action/create_queue</para>
        /// </summary>
        [NameInMap("actionArn")]
        [Validation(Required=false)]
        public string ActionArn { get; set; }

        /// <summary>
        /// <para>The ARN of the principal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:emr::workspaceId:user/23759369154162****</para>
        /// </summary>
        [NameInMap("principalArn")]
        [Validation(Required=false)]
        public string PrincipalArn { get; set; }

    }

}
