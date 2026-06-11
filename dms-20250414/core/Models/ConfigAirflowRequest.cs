// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ConfigAirflowRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the Airflow instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af-b3a7f110a6vmvn7xxxxxx</para>
        /// </summary>
        [NameInMap("AirflowId")]
        [Validation(Required=false)]
        public string AirflowId { get; set; }

        /// <summary>
        /// <para>The list of custom Airflow configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CustomAirflowCfg")]
        [Validation(Required=false)]
        public List<string> CustomAirflowCfg { get; set; }

        /// <summary>
        /// <para>The DMS workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8630242382****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
