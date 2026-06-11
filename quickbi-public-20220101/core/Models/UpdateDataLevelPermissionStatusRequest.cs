// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateDataLevelPermissionStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>The status of the permission switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: On</para>
        /// </description></item>
        /// <item><description><para>0: Off</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOpen")]
        [Validation(Required=false)]
        public int? IsOpen { get; set; }

        /// <summary>
        /// <para>The type of data-level permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ROW_LEVEL: Row-level permission</para>
        /// </description></item>
        /// <item><description><para>COLUMN_LEVEL: Column-level permission</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROW_LEVEL</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
