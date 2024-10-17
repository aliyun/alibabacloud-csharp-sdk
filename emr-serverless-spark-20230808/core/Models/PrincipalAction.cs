// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class PrincipalAction : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:emr::workspaceId:action/create_queue</para>
        /// </summary>
        [NameInMap("actionArn")]
        [Validation(Required=false)]
        public string ActionArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:emr::workspaceId:user/237593691541622267</para>
        /// </summary>
        [NameInMap("principalArn")]
        [Validation(Required=false)]
        public string PrincipalArn { get; set; }

    }

}
