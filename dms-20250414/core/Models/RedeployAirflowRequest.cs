// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class RedeployAirflowRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the Airflow instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af-b3a7f110a6vmvn7****</para>
        /// </summary>
        [NameInMap("AirflowId")]
        [Validation(Required=false)]
        public string AirflowId { get; set; }

        /// <summary>
        /// <para>The ID of the DMS workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
